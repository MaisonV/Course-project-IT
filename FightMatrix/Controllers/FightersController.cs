using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FightMatrix.Data;
using FightMatrix.Models;
using static FightMatrix.Helper;

namespace FightMatrix.Controllers
{
    public class FightersController : Controller
    {
        private readonly FightMatrixContext _context;

        public FightersController(FightMatrixContext context)
        {
            _context = context;
        }

        // GET: Fighters
        public async Task<IActionResult> Index(string searchString)
        {
            var fighters = from m in _context.Fighter
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                fighters = fighters.Where(s => s.Category.Contains(searchString));
            }

            fighters = fighters.OrderByDescending(k => k.RatingPoints);

            return View(await fighters.ToListAsync());
        }

        // GET: Fighters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fighter = await _context.Fighter.FirstOrDefaultAsync(m => m.ID == id);
            if (fighter == null)
            {
                return NotFound();
            }

            return View(fighter);
        }

        // GET: Fighters/AddOrEdit
        // GET: Fighters/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Fighter());
            }
            else
            {
                var fighter = await _context.Fighter.FindAsync(id);
                if (fighter == null)
                {
                    return NotFound();
                }
                return View(fighter);
            }
        }

        // POST: Fighters/AddOrEdit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Name,Age,Height,DebutDate,Promotion,Category,Wins,Loses,Draws,NC,RatingPoints")] Fighter fighter)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(fighter);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(fighter);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FighterExists(fighter.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Fighter.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", fighter) });
        }

        // GET: Fighters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fighter = await _context.Fighter
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fighter == null)
            {
                return NotFound();
            }

            return View(fighter);
        }

        // POST: Fighters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fighter = await _context.Fighter.FindAsync(id);
            _context.Fighter.Remove(fighter);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Fighter.ToList()) });
        }

        private bool FighterExists(int id)
        {
            return _context.Fighter.Any(e => e.ID == id);
        }
    }
}
