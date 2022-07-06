using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using FairWorks.BLManager.Abstract;
using FairWorks.WebUI.Areas.Admin.Models;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class KatalogGirisFormsController : Controller
    {
        private readonly FairWorksDbContext _context;
        

        public KatalogGirisFormsController(FairWorksDbContext context)
        {
            _context = context;
            
        }

        
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.KatalogGirisFormlari.Include(k => k.FirmaTip).Include(k => k.TemsilEttigiFirma).Include(k => k.UrunGrupları);
            return View(await fairWorksDbContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogGirisForm = await _context.KatalogGirisFormlari
                .Include(k => k.FirmaTip)
                .Include(k => k.TemsilEttigiFirma)
                .Include(k => k.UrunGrupları)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (katalogGirisForm == null)
            {
                return NotFound();
            }

            return View(katalogGirisForm);
        }

        
        public IActionResult Create()
        {
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTip");
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEdilenFirma");
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "UrunAdi");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirmaAdi,Adres,Telefon,Eposta,Faks,UrunId,FirmaTipId,TemsilEttigiFirmaId")] KatalogGirisForm katalogGirisForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(katalogGirisForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTip", katalogGirisForm.FirmaTip);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEdilenFirma", katalogGirisForm.TemsilEttigiFirma);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "UrunAdi", katalogGirisForm.UrunGrupları);
            return View(katalogGirisForm);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogGirisForm = await _context.KatalogGirisFormlari.FindAsync(id);
            if (katalogGirisForm == null)
            {
                return NotFound();
            }
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTip", katalogGirisForm.FirmaTip);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEdilenFirma", katalogGirisForm.TemsilEttigiFirma);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "UrunAdi", katalogGirisForm.UrunGrupları);
            return View(katalogGirisForm);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirmaAdi,Adres,Telefon,Eposta,Faks,UrunId,FirmaTipId,TemsilEttigiFirmaId")] KatalogGirisForm katalogGirisForm)
        {
            if (id != katalogGirisForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(katalogGirisForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KatalogGirisFormExists(katalogGirisForm.Id))
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
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTip", katalogGirisForm.FirmaTip);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEdilenFirma", katalogGirisForm.TemsilEttigiFirma);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "UrunAdi", katalogGirisForm.UrunGrupları);
            return View(katalogGirisForm);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var katalogGirisForm = await _context.KatalogGirisFormlari
                .Include(k => k.FirmaTip)
                .Include(k => k.TemsilEttigiFirma)
                .Include(k => k.UrunGrupları)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (katalogGirisForm == null)
            {
                return NotFound();
            }

            return View(katalogGirisForm);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var katalogGirisForm = await _context.KatalogGirisFormlari.FindAsync(id);
            _context.KatalogGirisFormlari.Remove(katalogGirisForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KatalogGirisFormExists(int id)
        {
            return _context.KatalogGirisFormlari.Any(e => e.Id == id);
        }
    }
}
