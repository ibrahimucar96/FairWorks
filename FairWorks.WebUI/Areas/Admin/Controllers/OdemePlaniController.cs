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
    public class OdemePlaniController : Controller
    {
        private readonly FairWorksDbContext _context;

        public OdemePlaniController(FairWorksDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View(await _context.OdemePlanlari.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odemePlani = await _context.OdemePlanlari
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odemePlani == null)
            {
                return NotFound();
            }

            return View(odemePlani);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VadeSayisi,Taksit,Faiz,Ay,Yıl,m2BirimFiyati,m2,indirimOrani")] OdemePlani odemePlani)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odemePlani);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(odemePlani);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odemePlani = await _context.OdemePlanlari.FindAsync(id);
            if (odemePlani == null)
            {
                return NotFound();
            }
            return View(odemePlani);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VadeSayisi,Taksit,Faiz,Ay,Yıl,m2BirimFiyati,m2,indirimOrani")] OdemePlani odemePlani)
        {
            if (id != odemePlani.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odemePlani);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdemePlaniExists(odemePlani.Id))
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
            return View(odemePlani);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odemePlani = await _context.OdemePlanlari
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odemePlani == null)
            {
                return NotFound();
            }

            return View(odemePlani);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odemePlani = await _context.OdemePlanlari.FindAsync(id);
            _context.OdemePlanlari.Remove(odemePlani);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OdemePlaniExists(int id)
        {
            return _context.OdemePlanlari.Any(e => e.Id == id);
        }
    }
}
