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
    public class ZiyaretciController : Controller
    {
        private readonly FairWorksDbContext _context;

        public ZiyaretciController(FairWorksDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Ziyaretciler.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ziyaretci = await _context.Ziyaretciler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ziyaretci == null)
            {
                return NotFound();
            }

            return View(ziyaretci);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirmaAdi,Yetkili,Unvani,Telefon,DahiliTelefon,DirektTelefon,Email,Faks,Adres,Sehir,Ulke,Sektor")] Ziyaretci ziyaretci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ziyaretci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ziyaretci);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ziyaretci = await _context.Ziyaretciler.FindAsync(id);
            if (ziyaretci == null)
            {
                return NotFound();
            }
            return View(ziyaretci);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirmaAdi,Yetkili,Unvani,Telefon,DahiliTelefon,DirektTelefon,Email,Faks,Adres,Sehir,Ulke,Sektor")] Ziyaretci ziyaretci)
        {
            if (id != ziyaretci.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ziyaretci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZiyaretciExists(ziyaretci.Id))
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
            return View(ziyaretci);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ziyaretci = await _context.Ziyaretciler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ziyaretci == null)
            {
                return NotFound();
            }

            return View(ziyaretci);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ziyaretci = await _context.Ziyaretciler.FindAsync(id);
            _context.Ziyaretciler.Remove(ziyaretci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZiyaretciExists(int id)
        {
            return _context.Ziyaretciler.Any(e => e.Id == id);
        }
    }
}
