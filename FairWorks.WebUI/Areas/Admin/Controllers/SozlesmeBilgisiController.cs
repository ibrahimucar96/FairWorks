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
    public class SozlesmeBilgisiController : Controller
    {
        private readonly FairWorksDbContext _context;

        public SozlesmeBilgisiController(FairWorksDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.SozlesmeBilgileri.Include(s => s.FirmaBilgileri).Include(s => s.OdemePlani).Include(s => s.PersonelAdi).Include(s => s.Salon).Include(s => s.SozlesmeTipleri).Include(s => s.Stand);
            return View(await fairWorksDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeBilgisi = await _context.SozlesmeBilgileri
                .Include(s => s.FirmaBilgileri)
                .Include(s => s.OdemePlani)
                .Include(s => s.PersonelAdi)
                .Include(s => s.Salon)
                .Include(s => s.SozlesmeTipleri)
                .Include(s => s.Stand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeBilgisi == null)
            {
                return NotFound();
            }

            return View(sozlesmeBilgisi);
        }

        
        public IActionResult Create()
        {
            ViewData["FirmaBilgileriId"] = new SelectList(_context.FirmaBilgileri, "Id", "FirmaAd");
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id");
            ViewData["PersonelId"] = new SelectList(_context.Personeller, "Id", "Ad");
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo");
            ViewData["SozlesmeTipiId"] = new SelectList(_context.SozlesmeTipleri, "Id", "SozlesmeTipleri");
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "StandKodu");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SozlesmeTarihi,PersonelId,FirmaBilgileriId,SozlesmeTipiId,StandId,OdemePlaniId,DovizCinsi,DovizKuru,SozlesmeSonGecerlilikTarihi,ImzaliSozlesmeDurumu,salonId")] SozlesmeBilgisi sozlesmeBilgisi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sozlesmeBilgisi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FirmaBilgileriId"] = new SelectList(_context.FirmaBilgileri, "Id", "FirmaAd", sozlesmeBilgisi.FirmaBilgileri);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", sozlesmeBilgisi.OdemePlaniId);
            ViewData["PersonelId"] = new SelectList(_context.Personeller, "Id", "Ad", sozlesmeBilgisi.PersonelAdi);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", sozlesmeBilgisi.Salon);
            ViewData["SozlesmeTipiId"] = new SelectList(_context.SozlesmeTipleri, "Id", "SozlesmeTipleri", sozlesmeBilgisi.SozlesmeTipleri);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "StandKodu", sozlesmeBilgisi.Stand);
            return View(sozlesmeBilgisi);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeBilgisi = await _context.SozlesmeBilgileri.FindAsync(id);
            if (sozlesmeBilgisi == null)
            {
                return NotFound();
            }
            ViewData["FirmaBilgileriId"] = new SelectList(_context.FirmaBilgileri, "Id", "FirmaAd", sozlesmeBilgisi.FirmaBilgileri);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", sozlesmeBilgisi.OdemePlaniId);
            ViewData["PersonelId"] = new SelectList(_context.Personeller, "Id", "Ad", sozlesmeBilgisi.PersonelAdi);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", sozlesmeBilgisi.Salon);
            ViewData["SozlesmeTipiId"] = new SelectList(_context.SozlesmeTipleri, "Id", "SozlesmeTipleri", sozlesmeBilgisi.SozlesmeTipleri);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "StandKodu", sozlesmeBilgisi.Stand);
            return View(sozlesmeBilgisi);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SozlesmeTarihi,PersonelId,FirmaBilgileriId,SozlesmeTipiId,StandId,OdemePlaniId,DovizCinsi,DovizKuru,SozlesmeSonGecerlilikTarihi,ImzaliSozlesmeDurumu,salonId")] SozlesmeBilgisi sozlesmeBilgisi)
        {
            if (id != sozlesmeBilgisi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sozlesmeBilgisi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SozlesmeBilgisiExists(sozlesmeBilgisi.Id))
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
            ViewData["FirmaBilgileriId"] = new SelectList(_context.FirmaBilgileri, "Id", "FirmaAd", sozlesmeBilgisi.FirmaBilgileri);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", sozlesmeBilgisi.OdemePlaniId);
            ViewData["PersonelId"] = new SelectList(_context.Personeller, "Id", "Ad", sozlesmeBilgisi.PersonelAdi);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "SalonNo", sozlesmeBilgisi.Salon);
            ViewData["SozlesmeTipiId"] = new SelectList(_context.SozlesmeTipleri, "Id", "SozlesmeTipleri", sozlesmeBilgisi.SozlesmeTipleri);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "StandKodu", sozlesmeBilgisi.Stand);
            return View(sozlesmeBilgisi);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sozlesmeBilgisi = await _context.SozlesmeBilgileri
                .Include(s => s.FirmaBilgileri)
                .Include(s => s.OdemePlani)
                .Include(s => s.PersonelAdi)
                .Include(s => s.Salon)
                .Include(s => s.SozlesmeTipleri)
                .Include(s => s.Stand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeBilgisi == null)
            {
                return NotFound();
            }

            return View(sozlesmeBilgisi);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sozlesmeBilgisi = await _context.SozlesmeBilgileri.FindAsync(id);
            _context.SozlesmeBilgileri.Remove(sozlesmeBilgisi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SozlesmeBilgisiExists(int id)
        {
            return _context.SozlesmeBilgileri.Any(e => e.Id == id);
        }
    }
}
