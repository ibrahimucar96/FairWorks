using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.DAL.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TemsilEttigiFirmaController : Controller
    {
        private readonly ITemsilEttigiFirmaManager manager;
        private readonly IMapper mapper;
        

        public TemsilEttigiFirmaController(ITemsilEttigiFirmaManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
            
        }
        public IActionResult Index()
        {
            var temsilEttigiFirma = manager.GetAll(null);
            return View(temsilEttigiFirma);
        }
        public IActionResult Create()
        {
            TemsilEttigiFirmaDto tef = new TemsilEttigiFirmaDto();
            return View(tef);
        }
        [HttpPost]
        public IActionResult Create(TemsilEttigiFirmaDto dto)
        {
            if (ModelState.IsValid)
            {
                var temsilEttigiFirma = mapper.Map<TemsilEttigiFirmaDto, TemsilEttigiFirma>(dto);
                manager.Add(temsilEttigiFirma);
                return RedirectToAction("Index", "TemsilEttigiFirma");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(TemsilEttigiFirma tef)
        {

            if (ModelState.IsValid)
            {
                manager.Update(tef);
                return RedirectToAction("Index", "TemsilEttigiFirma");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var values = manager.Find(id);
            manager.Delete(values);
            return RedirectToAction("Index", "TemsilEttigiFirma");
        }
        //[HttpPost]
        //public IActionResult Delete(TemsilEttigiFirma tef)
        //{
        //    manager.Delete(tef);
        //    return RedirectToAction("Index", "TemsilEttigiFirma");
        //}
    }
}
