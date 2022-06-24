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
    public class DovizsController : Controller
    {
        private readonly FairWorksDbContext _context;

        public DovizsController(FairWorksDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dovizler.ToListAsync());
        }

        // GET: Admin/Dovizs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doviz = await _context.Dovizler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doviz == null)
            {
                return NotFound();
            }

            return View(doviz);
        }

       
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DovizCinsi,DovizKuru")] Doviz doviz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doviz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doviz);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doviz = await _context.Dovizler.FindAsync(id);
            if (doviz == null)
            {
                return NotFound();
            }
            return View(doviz);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DovizCinsi,DovizKuru")] Doviz doviz)
        {
            if (id != doviz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doviz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DovizExists(doviz.Id))
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
            return View(doviz);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doviz = await _context.Dovizler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doviz == null)
            {
                return NotFound();
            }

            return View(doviz);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doviz = await _context.Dovizler.FindAsync(id);
            _context.Dovizler.Remove(doviz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DovizExists(int id)
        {
            return _context.Dovizler.Any(e => e.Id == id);
        }
    }
}
