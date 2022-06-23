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
    public class KatalogGirisFormsController : Controller
    {
        private readonly FairWorksDbContext _context;

        public KatalogGirisFormsController(FairWorksDbContext context)
        {
            _context = context;
        }

        // GET: Admin/KatalogGirisForms
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.KatalogGirisFormlari.Include(k => k.FirmaTip).Include(k => k.TemsilEttigiFirma).Include(k => k.UrunGrupları);
            return View(await fairWorksDbContext.ToListAsync());
        }

        // GET: Admin/KatalogGirisForms/Details/5
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

        // GET: Admin/KatalogGirisForms/Create
        public IActionResult Create()
        {
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId");
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId");
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "Id");
            return View();
        }

        // POST: Admin/KatalogGirisForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", katalogGirisForm.FirmaTipId);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", katalogGirisForm.TemsilEttigiFirmaId);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "Id", katalogGirisForm.UrunId);
            return View(katalogGirisForm);
        }

        // GET: Admin/KatalogGirisForms/Edit/5
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
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", katalogGirisForm.FirmaTipId);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", katalogGirisForm.TemsilEttigiFirmaId);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "Id", katalogGirisForm.UrunId);
            return View(katalogGirisForm);
        }

        // POST: Admin/KatalogGirisForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
            ViewData["FirmaTipId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", katalogGirisForm.FirmaTipId);
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", katalogGirisForm.TemsilEttigiFirmaId);
            ViewData["UrunId"] = new SelectList(_context.Urunler, "Id", "Id", katalogGirisForm.UrunId);
            return View(katalogGirisForm);
        }

        // GET: Admin/KatalogGirisForms/Delete/5
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

        // POST: Admin/KatalogGirisForms/Delete/5
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
