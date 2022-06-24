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
    public class TeklifBilgisiController : Controller
    {
        private readonly FairWorksDbContext _context;

        public TeklifBilgisiController(FairWorksDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.TeklifBilgileri.Include(t => t.Doviz).Include(t => t.OdemePlani).Include(t => t.Salon).Include(t => t.Stand);
            return View(await fairWorksDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teklifBilgisi = await _context.TeklifBilgileri
                .Include(t => t.Doviz)
                .Include(t => t.OdemePlani)
                .Include(t => t.Salon)
                .Include(t => t.Stand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teklifBilgisi == null)
            {
                return NotFound();
            }

            return View(teklifBilgisi);
        }

        public IActionResult Create()
        {
            ViewData["DovizId"] = new SelectList(_context.Dovizler, "Id", "Id");
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id");
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "Id");
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeklifTarihi,TeklifVerilenm2,m2birimFiyatı,StandId,DovizId,OdemePlaniId,TeklifinSonGecerlilikTarihi,salonId")] TeklifBilgisi teklifBilgisi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teklifBilgisi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DovizId"] = new SelectList(_context.Dovizler, "Id", "Id", teklifBilgisi.DovizId);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", teklifBilgisi.OdemePlaniId);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "Id", teklifBilgisi.salonId);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "Id", teklifBilgisi.StandId);
            return View(teklifBilgisi);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teklifBilgisi = await _context.TeklifBilgileri.FindAsync(id);
            if (teklifBilgisi == null)
            {
                return NotFound();
            }
            ViewData["DovizId"] = new SelectList(_context.Dovizler, "Id", "Id", teklifBilgisi.DovizId);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", teklifBilgisi.OdemePlaniId);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "Id", teklifBilgisi.salonId);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "Id", teklifBilgisi.StandId);
            return View(teklifBilgisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeklifTarihi,TeklifVerilenm2,m2birimFiyatı,StandId,DovizId,OdemePlaniId,TeklifinSonGecerlilikTarihi,salonId")] TeklifBilgisi teklifBilgisi)
        {
            if (id != teklifBilgisi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teklifBilgisi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeklifBilgisiExists(teklifBilgisi.Id))
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
            ViewData["DovizId"] = new SelectList(_context.Dovizler, "Id", "Id", teklifBilgisi.DovizId);
            ViewData["OdemePlaniId"] = new SelectList(_context.OdemePlanlari, "Id", "Id", teklifBilgisi.OdemePlaniId);
            ViewData["salonId"] = new SelectList(_context.Salonlar, "Id", "Id", teklifBilgisi.salonId);
            ViewData["StandId"] = new SelectList(_context.Standlar, "Id", "Id", teklifBilgisi.StandId);
            return View(teklifBilgisi);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teklifBilgisi = await _context.TeklifBilgileri
                .Include(t => t.Doviz)
                .Include(t => t.OdemePlani)
                .Include(t => t.Salon)
                .Include(t => t.Stand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teklifBilgisi == null)
            {
                return NotFound();
            }

            return View(teklifBilgisi);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teklifBilgisi = await _context.TeklifBilgileri.FindAsync(id);
            _context.TeklifBilgileri.Remove(teklifBilgisi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeklifBilgisiExists(int id)
        {
            return _context.TeklifBilgileri.Any(e => e.Id == id);
        }
    }
}
