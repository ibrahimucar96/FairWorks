using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FairWorks.WebUI.Models;
using Microsoft.AspNetCore.Authorization;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BiletliZiyaretciController : Controller
    {
        private readonly IBiletliZiyaretciManager manager;

        public BiletliZiyaretciController(IBiletliZiyaretciManager manager)
        {
            ;
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var biletliZiyaretci = manager.GetAll(null);
            //ViewBag.Urunler = new List<Urunler> { new Urunler { Id = 2, UrunAdi = "ReklamPanosu", Adet = 1, Fiyat = 100, UrunKodu = 321, UrunBilgileri = "TürkYapimi" } };
            return View(biletliZiyaretci);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BiletliZiyaretci entity = new BiletliZiyaretci();
            

            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(BiletliZiyaretci bz)
        {
            if (ModelState.IsValid)
            {
                manager.Add(bz);
                return RedirectToAction("Index","BiletliZiyaretci");
                
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(BiletliZiyaretci biletliZiyaretci)
        {
            if (ModelState.IsValid)
            {
                manager.Update(biletliZiyaretci);
                return RedirectToAction("Index", "BiletliZiyaretci");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Delete(BiletliZiyaretci bz)
        {
            manager.Delete(bz);
            return RedirectToAction("Index", "BiletliZiyaretci");
        }
    }
}
