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
    public class PotansiyelFirmaController : Controller
    {
        private readonly FairWorksDbContext _context;

        public PotansiyelFirmaController(FairWorksDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.PotansiyelFirmalar.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var potansiyelFirma = await _context.PotansiyelFirmalar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (potansiyelFirma == null)
            {
                return NotFound();
            }

            return View(potansiyelFirma);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirmaAdı,Yetkili,Unvani,Telefon,DahiliTelefon,DirektTelefon,Email,Faks,Adres,Ulke,Sehir,Sektor")] PotansiyelFirma potansiyelFirma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(potansiyelFirma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(potansiyelFirma);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var potansiyelFirma = await _context.PotansiyelFirmalar.FindAsync(id);
            if (potansiyelFirma == null)
            {
                return NotFound();
            }
            return View(potansiyelFirma);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirmaAdı,Yetkili,Unvani,Telefon,DahiliTelefon,DirektTelefon,Email,Faks,Adres,Ulke,Sehir,Sektor")] PotansiyelFirma potansiyelFirma)
        {
            if (id != potansiyelFirma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(potansiyelFirma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PotansiyelFirmaExists(potansiyelFirma.Id))
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
            return View(potansiyelFirma);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var potansiyelFirma = await _context.PotansiyelFirmalar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (potansiyelFirma == null)
            {
                return NotFound();
            }

            return View(potansiyelFirma);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var potansiyelFirma = await _context.PotansiyelFirmalar.FindAsync(id);
            _context.PotansiyelFirmalar.Remove(potansiyelFirma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PotansiyelFirmaExists(int id)
        {
            return _context.PotansiyelFirmalar.Any(e => e.Id == id);
        }
    }
}
