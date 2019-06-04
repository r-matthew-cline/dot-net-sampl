using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PickEm.Models;

namespace PickEm.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly PickEmContext _context;

        public TeamController(PickEmContext context)
        {
            _context = context;
        }

        // GET: Team
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamModel.ToListAsync());
        }

        // GET: Team/GetStats
        public async Task<IActionResult> GetStats()
        {
            var teams = _context.TeamModel.ToList();

            foreach (var team in teams)
            {
                string url = "http://stats.clinetechnologysolutions.com/get-stats/" + team.TeamId.ToString();
                using (HttpClient client = new HttpClient())
                {
                    var response = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(await client.GetStringAsync(url));
                    team.AvgAst = response["Ast"];
                    team.AvgBlk = response["Blk"];
                    team.AvgDefReb = response["DefReb"];
                    team.AvgOffReb = response["OffReb"];
                    team.AvgOppScore = response["OppScore"];
                    team.AvgScore = response["Score"];
                    team.AvgStl = response["Stl"];
                }
                _context.Update(team);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Team/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamModel = await _context.TeamModel
                .FirstOrDefaultAsync(m => m.TeamId == id);
            if (teamModel == null)
            {
                return NotFound();
            }

            return View(teamModel);
        }

        // GET: Team/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamId,Name,AvgScore,AvgOppScore,AvgOffReb,AvgDefReb,AvgStl,AvgBlk,AvgAst,Seed")] TeamModel teamModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamModel);
        }

        // GET: Team/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamModel = await _context.TeamModel.FindAsync(id);
            if (teamModel == null)
            {
                return NotFound();
            }
            return View(teamModel);
        }

        // POST: Team/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamId,Name,AvgScore,AvgOppScore,AvgOffReb,AvgDefReb,AvgStl,AvgBlk,AvgAst,Seed")] TeamModel teamModel)
        {
            if (id != teamModel.TeamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamModelExists(teamModel.TeamId))
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
            return View(teamModel);
        }

        // GET: Team/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamModel = await _context.TeamModel
                .FirstOrDefaultAsync(m => m.TeamId == id);
            if (teamModel == null)
            {
                return NotFound();
            }

            return View(teamModel);
        }

        // POST: Team/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamModel = await _context.TeamModel.FindAsync(id);
            _context.TeamModel.Remove(teamModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamModelExists(int id)
        {
            return _context.TeamModel.Any(e => e.TeamId == id);
        }
    }
}
