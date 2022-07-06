using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class GorusulenFirmaController : Controller
    {
        private readonly IGorusulenFirmaManager manager;
        private readonly IMapper mapper;
        private readonly IPersonelManager personel;
        private readonly FairWorksDbContext context;

        public GorusulenFirmaController(IGorusulenFirmaManager manager, IMapper mapper, IPersonelManager personel,FairWorksDbContext context)
        {
            this.manager = manager;
            this.mapper = mapper;
            this.personel = personel;
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = context.GorusulenFirmalar.Include(p => p.PersonelAdı);
            return View(await fairWorksDbContext.ToListAsync());
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            var gorusulenFirma = new GorusulenFirmaCreateDto();
            var _personel = personel.GetAll(null);
            List<PersonelModel> personelSelectList = new();
            foreach (var item in _personel)
            {
                personelSelectList.Add(new PersonelModel
                {
                    Id = item.Id,
                    Ad = item.Ad,
                    SoyAd = item.SoyAd
                });
            }
            ViewBag.Personel = new SelectList(personelSelectList, "Id", "Ad", "SoyAd");
            return View(gorusulenFirma);
        }
        [HttpPost]
        public IActionResult Create(GorusulenFirmaCreateDto gorusulenFirma)
        {
            if (ModelState.IsValid)
            {
                var gf = mapper.Map<GorusulenFirmaCreateDto, GorusulenFirma>(gorusulenFirma);
                manager.Add(gf);
                return RedirectToAction("Index", "GorusulenFirma", new { Areas = "Admin" });
            }
            return View(gorusulenFirma);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var gorusulenFirma = manager.Find(id);
            var updateDto = mapper.Map<GorusulenFirma, GorusulenFirmaCreateDto>(gorusulenFirma);

            var pers = personel.GetAll(null);
            List<PersonelModel> personelModel = new();
            foreach (var item in pers)
            {
                personelModel.Add(new PersonelModel { Id = item.Id, Ad = item.Ad });
            }
            var personelSelectList = new SelectList(personelModel, "Id", "Ad");
            ViewBag.Personel = personelSelectList;
            return View(updateDto);
        }
        [HttpPost]
        public IActionResult Update(GorusulenFirmaCreateDto update)
        {
            if (ModelState.IsValid)
            {
                var gorusulenFirma = mapper.Map<GorusulenFirmaCreateDto, GorusulenFirma>(update);
                
                    manager.Update(gorusulenFirma);
                    return RedirectToAction("Index", "GorusulenFirma");
                
            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            var values = manager.Find(id);
            manager.Delete(values);
            return RedirectToAction("Index", "GorusulenFirma");
        }
    }
}

