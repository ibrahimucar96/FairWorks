using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class StandController : Controller
    {
        private readonly FairWorksDbContext _context;

        public StandController(FairWorksDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.Standlar.Include(s => s.Salonlar);
            return View(await fairWorksDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stand = await _context.Standlar
                .Include(s => s.Salonlar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stand == null)
            {
                return NotFound();
            }

            return View(stand);
        }

        
        public IActionResult Create()
        {
            ViewData["SalonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StandTipi,StandKodu,SalonId")] Stand stand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SalonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", stand.Salonlar);
            return View(stand);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stand = await _context.Standlar.FindAsync(id);
            if (stand == null)
            {
                return NotFound();
            }
            ViewData["SalonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", stand.Salonlar);
            return View(stand);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StandTipi,StandKodu,SalonId")] Stand stand)
        {
            if (id != stand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StandExists(stand.Id))
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
            ViewData["SalonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", stand.Salonlar);
            return View(stand);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stand = await _context.Standlar
                .Include(s => s.Salonlar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stand == null)
            {
                return NotFound();
            }

            return View(stand);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stand = await _context.Standlar.FindAsync(id);
            _context.Standlar.Remove(stand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StandExists(int id)
        {
            return _context.Standlar.Any(e => e.Id == id);
        }
    }
}
