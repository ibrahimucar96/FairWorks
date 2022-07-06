using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.DAL.EFCore;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaBilgiController : Controller
    {
        private readonly IFirmaBilgiManager manager;
        private readonly IMapper mapper;
        private readonly IUcretsizVerilenAlanManager ucretsizVerilenAlan;
        private readonly FairWorksDbContext context;

        public FirmaBilgiController(IFirmaBilgiManager manager,IMapper mapper,IUcretsizVerilenAlanManager ucretsizVerilenAlan,FairWorksDbContext context)
        {
            this.manager = manager;
            this.mapper = mapper;
            this.ucretsizVerilenAlan = ucretsizVerilenAlan;
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var fairWorksDbContext = context.FirmaBilgileri.Include(u => u.UcretsizVerilenAlanlar);
            return View(await fairWorksDbContext.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            var firmabilgi = new FirmaBilgiCreateDto();
            var alanlar = ucretsizVerilenAlan.GetAll(null);
            List<UcretsizVerilenAlanModel> alanSelectList = new();
            foreach (var item in alanlar)
            {
                alanSelectList.Add(new UcretsizVerilenAlanModel { UcretsizVerilenAlanId=item.UcretsizVerilenAlanId,UcretsizVerilenm2 = item.UcretsizVerilenm2 });
            }
            ViewBag.Alanlar = new SelectList(alanSelectList, "UcretsizVerilenAlanId", "UcretsizVerilenm2");
            return View(firmabilgi);            
        }
        [HttpPost]
        public IActionResult Create(FirmaBilgiCreateDto firmaBilgi)
        {
            if (ModelState.IsValid)
            {
                var fb = mapper.Map<FirmaBilgiCreateDto, FirmaBilgi>(firmaBilgi);                                               
                    manager.CheckForVergiNo(fb.VergiNumarası);
                    manager.Add(fb);
                    return RedirectToAction("Index", "FirmaBilgi", new { Areas = "Admin" });      
            }
            return View(firmaBilgi);
        } 
        [HttpGet]
        public IActionResult Update(int id)
        {
            var firmaBilgi = manager.Find(id);
            var updateDto = mapper.Map<FirmaBilgi, FirmaBilgiCreateDto>(firmaBilgi);
            
            var alan = ucretsizVerilenAlan.GetAll(null);
            List<UcretsizVerilenAlanModel> alanModel = new();
            foreach (var item in alan)
            {
                alanModel.Add(new UcretsizVerilenAlanModel { UcretsizVerilenAlanId = item.UcretsizVerilenAlanId, UcretsizVerilenm2=item.UcretsizVerilenm2 });
            }
            var alanSelectList = new SelectList(alanModel, "UcretsizVerilenAlanId", "UcretsizVerilenm2");
            ViewBag.Alanlar = alanSelectList;
            return View(updateDto);
        }
        [HttpPost]
        public IActionResult Update(FirmaBilgiCreateDto update)
        {
            if (ModelState.IsValid)
            {
                var firmaBilgi = mapper.Map<FirmaBilgiCreateDto, FirmaBilgi>(update);
                if (!manager.CheckForVergiNo(update.VergiNumarası))
                {
                    
                    manager.Update(firmaBilgi);
                    return RedirectToAction("Index", "FirmaBilgi");
                }                                  
            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            var values = manager.Find(id);
            manager.Delete(values);
            return RedirectToAction("Index", "FirmaBilgi");
        }        
    }    
}
