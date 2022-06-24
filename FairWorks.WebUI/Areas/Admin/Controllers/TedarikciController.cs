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
    public class TedarikciController : Controller
    {
        private readonly FairWorksDbContext _context;

        public TedarikciController(FairWorksDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Tedarikciler.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tedarikci = await _context.Tedarikciler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tedarikci == null)
            {
                return NotFound();
            }

            return View(tedarikci);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tedarikciler")] Tedarikci tedarikci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tedarikci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tedarikci);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tedarikci = await _context.Tedarikciler.FindAsync(id);
            if (tedarikci == null)
            {
                return NotFound();
            }
            return View(tedarikci);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tedarikciler")] Tedarikci tedarikci)
        {
            if (id != tedarikci.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tedarikci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TedarikciExists(tedarikci.Id))
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
            return View(tedarikci);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tedarikci = await _context.Tedarikciler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tedarikci == null)
            {
                return NotFound();
            }

            return View(tedarikci);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tedarikci = await _context.Tedarikciler.FindAsync(id);
            _context.Tedarikciler.Remove(tedarikci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TedarikciExists(int id)
        {
            return _context.Tedarikciler.Any(e => e.Id == id);
        }
    }
}
