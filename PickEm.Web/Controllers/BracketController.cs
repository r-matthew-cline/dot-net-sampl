using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickEm.Models;

namespace PickEm.Web.Controllers
{
    public class BracketController : Controller
    {
        private readonly PickEmContext _context;

        public BracketController(PickEmContext context)
        {
            _context = context;
        }

        // GET: Bracket
        public async Task<IActionResult> Index()
        {
            return View(await _context.BracketModel.ToListAsync());
        }

        // GET: Bracket/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bracketModel = await _context.BracketModel
		    .Include(b => b.Games).ThenInclude(g => g.HomeTeam)
		    .Include(b => b.Games).ThenInclude(b => b.AwayTeam)
		    .FirstOrDefaultAsync(m => m.Id == id);
            if (bracketModel == null)
            {
                return NotFound();
            }

            return View(bracketModel);
        }

        // GET: Bracket/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bracket/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] BracketModel bracketModel)
        {
            bracketModel.Games = new List<GameModel>(63);
            bracketModel.CorrectPicks = 0;
            if (ModelState.IsValid)
            {
                _context.Add(bracketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Pick", "Bracket", new { bracketId = bracketModel.Id, bracketPosition = 0});
            }
            return View(bracketModel);
        }

        // GET: Bracket/Pick?bracketId=1&game=1
        public IActionResult Pick(int bracketId, int bracketPosition)
        {
            var bracketModel = _context.BracketModel.Include(b => b.Games).Where(b => b.Id == bracketId).Single();
            if (bracketModel == null)
            {
                return NotFound();
            }

            var initial_games = new List<(int home, int away)>
                {
                    (1181, 1295),
                    (1433, 1416),
                    (1280, 1251),
                    (1439, 1387),
                    (1268, 1125),
                    (1261, 1463),
                    (1257, 1278),
                    (1277, 1133),
                    (1211, 1192), 
                    (1393, 1124),
                    (1266, 1293),
                    (1199, 1436),
                    (1138, 1113),
                    (1403, 1297),
                    (1305, 1196),
                    (1276, 1285),
                    (1438, 1205),
                    (1279, 1328), 
                    (1458, 1332),
                    (1243, 1414),
                    (1437, 1388),
                    (1345, 1330),
                    (1153, 1234),
                    (1397, 1159),
                    (1314, 1233),
                    (1429, 1449),
                    (1120, 1308),
                    (1242, 1318),
                    (1235, 1326),
                    (1222, 1209),
                    (1459, 1371),
                    (1246, 1101)

                };

            int homeId = 0;
            int awayId = 0;
            if (bracketPosition < 32)
            {
                homeId = initial_games[bracketPosition].home;
                awayId = initial_games[bracketPosition].away;
            }
            else if (bracketPosition > 31 && bracketPosition < 48)
            {
                GameModel first_game = bracketModel.Games[bracketPosition - 32 + (bracketPosition % 16)];
                GameModel second_game = bracketModel.Games[bracketPosition - 31 + (bracketPosition % 16)];
                if (first_game.Prediction.Value)
                {
                    homeId = first_game.HomeTeamId.Value;
                }
                else 
                {
                    homeId = first_game.AwayTeamId.Value;
                }
                if (second_game.Prediction.Value)
                {
                    awayId = second_game.HomeTeamId.Value;
                }
                else{
                    awayId = second_game.AwayTeamId.Value;
                }
            }
            else if (bracketPosition > 47 && bracketPosition < 56)
            {
                GameModel first_game = bracketModel.Games[bracketPosition - 16 + (bracketPosition % 8)];
                GameModel second_game = bracketModel.Games[bracketPosition - 15 + (bracketPosition % 8)];
                if (first_game.Prediction.Value)
                {
                    homeId = first_game.HomeTeamId.Value;
                }
                else 
                {
                    homeId = first_game.AwayTeamId.Value;
                }
                if (second_game.Prediction.Value)
                {
                    awayId = second_game.HomeTeamId.Value;
                }
                else{
                    awayId = second_game.AwayTeamId.Value;
                }
            }
            else if (bracketPosition > 55 && bracketPosition < 60)
            {
                GameModel first_game = bracketModel.Games[bracketPosition - 8 + (bracketPosition % 4)];
                GameModel second_game = bracketModel.Games[bracketPosition - 7 + (bracketPosition % 4)];
                if (first_game.Prediction.Value)
                {
                    homeId = first_game.HomeTeamId.Value;
                }
                else 
                {
                    homeId = first_game.AwayTeamId.Value;
                }
                if (second_game.Prediction.Value)
                {
                    awayId = second_game.HomeTeamId.Value;
                }
                else{
                    awayId = second_game.AwayTeamId.Value;
                }
            }
            else if (bracketPosition > 59 && bracketPosition < 62)
            {
                GameModel first_game = bracketModel.Games[bracketPosition - 4 + (bracketPosition % 2)];
                GameModel second_game = bracketModel.Games[bracketPosition - 3 + (bracketPosition % 2)];
                if (first_game.Prediction.Value)
                {
                    homeId = first_game.HomeTeamId.Value;
                }
                else 
                {
                    homeId = first_game.AwayTeamId.Value;
                }
                if (second_game.Prediction.Value)
                {
                    awayId = second_game.HomeTeamId.Value;
                }
                else{
                    awayId = second_game.AwayTeamId.Value;
                }
            }
            else
            {
                GameModel first_game = bracketModel.Games[bracketPosition - 2];
                GameModel second_game = bracketModel.Games[bracketPosition - 1];
                if (first_game.Prediction.Value)
                {
                    homeId = first_game.HomeTeamId.Value;
                }
                else 
                {
                    homeId = first_game.AwayTeamId.Value;
                }
                if (second_game.Prediction.Value)
                {
                    awayId = second_game.HomeTeamId.Value;
                }
                else{
                    awayId = second_game.AwayTeamId.Value;
                }
            }

            return RedirectToAction("PickGame", "Game", new { homeId = homeId, awayId = awayId, bracketId = bracketId, bracketPosition = bracketPosition});
        }

        // GET: Bracket/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bracketModel = await _context.BracketModel.FindAsync(id);
            if (bracketModel == null)
            {
                return NotFound();
            }
            return View(bracketModel);
        }

        // POST: Bracket/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CorrectPicks")] BracketModel bracketModel)
        {
            if (id != bracketModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bracketModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BracketModelExists(bracketModel.Id))
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
            return View(bracketModel);
        }

        // GET: Bracket/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bracketModel = await _context.BracketModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bracketModel == null)
            {
                return NotFound();
            }

            return View(bracketModel);
        }

        // POST: Bracket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bracketModel = await _context.BracketModel.FindAsync(id);
            _context.BracketModel.Remove(bracketModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BracketModelExists(int id)
        {
            return _context.BracketModel.Any(e => e.Id == id);
        }
    }
}
