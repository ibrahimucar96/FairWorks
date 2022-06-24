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
    public class SozlesmeTipiController : Controller
    {
        private readonly FairWorksDbContext _context;

        public SozlesmeTipiController(FairWorksDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.SozlesmeTipleri.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeTipi = await _context.SozlesmeTipleri
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeTipi == null)
            {
                return NotFound();
            }

            return View(sozlesmeTipi);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SozlesmeTipleri")] SozlesmeTipi sozlesmeTipi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sozlesmeTipi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sozlesmeTipi);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeTipi = await _context.SozlesmeTipleri.FindAsync(id);
            if (sozlesmeTipi == null)
            {
                return NotFound();
            }
            return View(sozlesmeTipi);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SozlesmeTipleri")] SozlesmeTipi sozlesmeTipi)
        {
            if (id != sozlesmeTipi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sozlesmeTipi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SozlesmeTipiExists(sozlesmeTipi.Id))
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
            return View(sozlesmeTipi);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeTipi = await _context.SozlesmeTipleri
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeTipi == null)
            {
                return NotFound();
            }

            return View(sozlesmeTipi);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sozlesmeTipi = await _context.SozlesmeTipleri.FindAsync(id);
            _context.SozlesmeTipleri.Remove(sozlesmeTipi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SozlesmeTipiExists(int id)
        {
            return _context.SozlesmeTipleri.Any(e => e.Id == id);
        }
    }
}
