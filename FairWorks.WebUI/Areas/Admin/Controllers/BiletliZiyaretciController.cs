using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FairWorks.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using FairWorks.WebUI.Areas.Admin.Models.Dto;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class BiletliZiyaretciController : Controller
    {
        private readonly IBiletliZiyaretciManager manager;
        private readonly IMapper mapper;

        public BiletliZiyaretciController(IBiletliZiyaretciManager manager,IMapper mapper)
        {
            ;
            this.manager = manager;
            this.mapper = mapper;
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
            BiletliZiyaretciDto entity = new BiletliZiyaretciDto();
            

            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(BiletliZiyaretciDto bz)
        {
            if (ModelState.IsValid)
            {
                var biletliZiyaretci = mapper.Map<BiletliZiyaretciDto, BiletliZiyaretci>(bz);
                manager.Add(biletliZiyaretci);
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
        public IActionResult Delete(BiletliZiyaretci biletli)
        {
            manager.Delete(biletli);
            return RedirectToAction("Index", "BiletliZiyaretci");

        }
    }
}
