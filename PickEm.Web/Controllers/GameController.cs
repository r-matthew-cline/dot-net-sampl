using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PickEm.Models;
using PickEm.ViewModels;

namespace PickEm.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly PickEmContext _context;

        public GameController(PickEmContext context)
        {
            _context = context;
        }

        // GET: Game
        public async Task<IActionResult> Index()
        {
            /*
            var viewModel = new GameIndexViewModel();
            viewModel.Games = _context.GameModel;
            viewModel.Teams = _context.TeamModel;
            return View(viewModel);
            */
            return View(await _context.GameModel.Include(g => g.HomeTeam).Include(g => g.AwayTeam).ToListAsync());
        }

        // GET: Game/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameModel = await _context.GameModel.Include(g => g.HomeTeam).Include(g => g.AwayTeam)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameModel == null)
            {
                return NotFound();
            }

            return View(gameModel);
        }

        // GET: Game/Create
        public IActionResult Create()
        {
            var viewModel = new GameCreateViewModel();
            viewModel.Teams = _context.TeamModel;
            return View(viewModel);
        }

        // POST: Game/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewModel.gameModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Game/PickGame?homeId=1&awayId=2&bracketId=3&bracketPosition
        public async Task<IActionResult>  PickGame(int homeId, int awayId, int bracketId, int bracketPosition)
        {
	    string pred_call = "http://localhost:5200/" + homeId.ToString() + "/" + awayId.ToString();
	    using (HttpClient client = new HttpClient())
	    {
	       var response = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(await client.GetStringAsync(pred_call));
	       ViewData["HomePred"] = response[homeId.ToString()];
       	       ViewData["AwayPred"] = response[awayId.ToString()];	       
	    }
            var gameModel = new GameModel();
            gameModel.HomeTeamId = homeId;
            gameModel.AwayTeamId = awayId;
            gameModel.BracketId = bracketId;
            gameModel.BracketPosition = bracketPosition;
            gameModel.HomeTeam = _context.TeamModel.Where(t => t.TeamId == homeId).Single();
            gameModel.AwayTeam = _context.TeamModel.Where(t => t.TeamId == awayId).Single();
            return View(gameModel);
        }

        // POST: Game/PickGame?homeId=1&awayId=2
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PickGame(int homeId, int awayId,[Bind("Id,HomeTeam,AwayTeam,HomeTeamId,AwayTeamId,HomeScore,AwayScore,BracketId,BracketPosition,Prediction")] GameModel gameModel)
        {
            if (ModelState.IsValid)
            {
                var bracket = _context.BracketModel.Include(b => b.Games).Where(b => b.Id == gameModel.BracketId).Single();
                bracket.Games.Append(gameModel);
                _context.Update(bracket);
                _context.Add(gameModel);
                await _context.SaveChangesAsync();
                if (gameModel.BracketPosition < 62)
                {
                    int nextGame = gameModel.BracketPosition.Value + 1;
                    return RedirectToAction("Pick", "Bracket", new { bracketId = gameModel.BracketId.Value, bracketPosition = nextGame});
                }
                return RedirectToAction("Index", "Bracket", new { area = ""});
                
            }
            return View(gameModel);
        }

        // GET: Game/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameModel = await _context.GameModel.FindAsync(id);
            if (gameModel == null)
            {
                return NotFound();
            }
            return View(gameModel);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HomeTeamId,AwayTeamId,HomeScore,AwayScore,Prediction")] GameModel gameModel)
        {
            if (id != gameModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameModelExists(gameModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gameModel);
        }

        // GET: Game/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameModel = await _context.GameModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameModel == null)
            {
                return NotFound();
            }

            return View(gameModel);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameModel = await _context.GameModel.FindAsync(id);
            _context.GameModel.Remove(gameModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameModelExists(int id)
        {
            return _context.GameModel.Any(e => e.Id == id);
        }
    }
}
