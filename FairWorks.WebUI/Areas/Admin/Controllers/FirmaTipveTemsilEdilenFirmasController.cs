using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FairWorks.Domain.Entities;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FirmaTipveTemsilEdilenFirmasController : Controller
    {
        private readonly FairWorksDbContext _context;

        public FirmaTipveTemsilEdilenFirmasController(FairWorksDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FirmaTipveTemsilEdilenFirmas
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = _context.FirmaTipiveFirmalar.Include(f => f.FirmaTipi).Include(f => f.TemsilEttigiFirma);
            return View(await fairWorksDbContext.ToListAsync());
        }

        // GET: Admin/FirmaTipveTemsilEdilenFirmas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmaTipveTemsilEdilenFirma = await _context.FirmaTipiveFirmalar
                .Include(f => f.FirmaTipi)
                .Include(f => f.TemsilEttigiFirma)
                .FirstOrDefaultAsync(m => m.TemsilEttigiFirmaId == id);
            if (firmaTipveTemsilEdilenFirma == null)
            {
                return NotFound();
            }

            return View(firmaTipveTemsilEdilenFirma);
        }

        // GET: Admin/FirmaTipveTemsilEdilenFirmas/Create
        public IActionResult Create()
        {
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId");
            ViewData["FirmaTipId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId");
            return View();
        }

        // POST: Admin/FirmaTipveTemsilEdilenFirmas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TemsilEttigiFirmaId,FirmaTipId")] FirmaTipveTemsilEdilenFirma firmaTipveTemsilEdilenFirma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(firmaTipveTemsilEdilenFirma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", firmaTipveTemsilEdilenFirma.TemsilEttigiFirmaId);
            ViewData["FirmaTipId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", firmaTipveTemsilEdilenFirma.FirmaTipId);
            return View(firmaTipveTemsilEdilenFirma);
        }

        // GET: Admin/FirmaTipveTemsilEdilenFirmas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmaTipveTemsilEdilenFirma = await _context.FirmaTipiveFirmalar.FindAsync(id);
            if (firmaTipveTemsilEdilenFirma == null)
            {
                return NotFound();
            }
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", firmaTipveTemsilEdilenFirma.TemsilEttigiFirmaId);
            ViewData["FirmaTipId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", firmaTipveTemsilEdilenFirma.FirmaTipId);
            return View(firmaTipveTemsilEdilenFirma);
        }

        // POST: Admin/FirmaTipveTemsilEdilenFirmas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TemsilEttigiFirmaId,FirmaTipId")] FirmaTipveTemsilEdilenFirma firmaTipveTemsilEdilenFirma)
        {
            if (id != firmaTipveTemsilEdilenFirma.TemsilEttigiFirmaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(firmaTipveTemsilEdilenFirma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirmaTipveTemsilEdilenFirmaExists(firmaTipveTemsilEdilenFirma.TemsilEttigiFirmaId))
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
            ViewData["TemsilEttigiFirmaId"] = new SelectList(_context.FirmaTipleri, "FirmaTipId", "FirmaTipId", firmaTipveTemsilEdilenFirma.TemsilEttigiFirmaId);
            ViewData["FirmaTipId"] = new SelectList(_context.TemsilEttigiFirmalar, "TemsilEttigiFirmaId", "TemsilEttigiFirmaId", firmaTipveTemsilEdilenFirma.FirmaTipId);
            return View(firmaTipveTemsilEdilenFirma);
        }

        // GET: Admin/FirmaTipveTemsilEdilenFirmas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmaTipveTemsilEdilenFirma = await _context.FirmaTipiveFirmalar
                .Include(f => f.FirmaTipi)
                .Include(f => f.TemsilEttigiFirma)
                .FirstOrDefaultAsync(m => m.TemsilEttigiFirmaId == id);
            if (firmaTipveTemsilEdilenFirma == null)
            {
                return NotFound();
            }

            return View(firmaTipveTemsilEdilenFirma);
        }

        // POST: Admin/FirmaTipveTemsilEdilenFirmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var firmaTipveTemsilEdilenFirma = await _context.FirmaTipiveFirmalar.FindAsync(id);
            _context.FirmaTipiveFirmalar.Remove(firmaTipveTemsilEdilenFirma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FirmaTipveTemsilEdilenFirmaExists(int id)
        {
            return _context.FirmaTipiveFirmalar.Any(e => e.TemsilEttigiFirmaId == id);
        }
    }
}
