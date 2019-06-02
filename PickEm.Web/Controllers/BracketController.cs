using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Create([Bind("Id,CorrectPicks")] BracketModel bracketModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bracketModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bracketModel);
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
