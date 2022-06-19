using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaController : Controller
    {
        private readonly IFirmaManager manager;
        private readonly IMapper mapper;

        public FirmaController(IFirmaManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }
       
        public IActionResult Index()
        {
            var firma = manager.GetAll(null);
            return View(firma);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FirmaDto entity = new FirmaDto();


            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(FirmaDto firma)
        {
            if (ModelState.IsValid)
            {
                var f = mapper.Map<FirmaDto, Firma>(firma);
                manager.CheckForFirmaAdi(f.FirmaAd);
                manager.Add(f);
                return RedirectToAction("Index", "Firma");

            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Firma firma)
        {
            if (ModelState.IsValid)
            {
                manager.Update(firma);
                return RedirectToAction("Index", "Firma");
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
        public IActionResult Delete(Firma firma)
        {
            manager.Delete(firma);
            return RedirectToAction("Index", "Firma");
        }
    }
}
