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
using System;
using System.Collections.Generic;
using System.Linq;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaBilgiController : Controller
    {
        private readonly IFirmaBilgiManager manager;
        private readonly IMapper mapper;
        private readonly IUcretsizVerilenAlanManager ucretsizVerilenAlan;

        public FirmaBilgiController(IFirmaBilgiManager manager,IMapper mapper,IUcretsizVerilenAlanManager ucretsizVerilenAlan)
        {
            this.manager = manager;
            this.mapper = mapper;
            this.ucretsizVerilenAlan = ucretsizVerilenAlan;
        }
        public IActionResult Index()
        {
            List<FirmaBilgi> firmaBilgi = new List<FirmaBilgi>();
            firmaBilgi = manager.GetAll(null);
            

            if (firmaBilgi.Count == 0)
                firmaBilgi.Add(new FirmaBilgi());

            return View(firmaBilgi);                           
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
                
                try
                {
                    manager.CheckForVergiNo(fb.VergiNumarası);
                    manager.Add(fb);
                    return RedirectToAction("Index", "FirmaBilgi", new { Areas = "Admin" });
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("",ex.Message);
                }
                

            }
            return View(firmaBilgi);
        } 
        [HttpGet]
        public IActionResult Update(int id)
        {
            var firmaBilgi = manager.Find(id);
            var updateDto = mapper.Map<FirmaBilgi, FirmaBilgiCreateDto>(firmaBilgi);
            return View(updateDto);
        }
        [HttpPost]
        public IActionResult Update(FirmaBilgiCreateDto update)
        {
            return View();
        }
    }    
}
