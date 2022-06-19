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
            var firmaBilgi = manager.GetAll(null);
            return View(firmaBilgi);
            
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            FirmaBilgiCreateDto createDto = new FirmaBilgiCreateDto();

            createDto.FirmaBilgiDto = new FirmaBilgiDto();

            var ucretsiz = ucretsizVerilenAlan.GetAll(null);
            var alan = mapper.Map<List<UcretsizVerilenAlan>, List<UcretsizVerilenAlanModel>>(ucretsiz);
            createDto.UcretsizVerilenAlan = new SelectList(alan, "UcretsizVerilenAlanId", "UcretsizVerilenm2");

            return View(createDto);
        }
        [HttpPost]
        public IActionResult Create(FirmaBilgiDto firmaBilgi)
        {
            if (ModelState.IsValid)
            {
                var fb = mapper.Map<FirmaBilgiDto, FirmaBilgi>(firmaBilgi);
                try
                {
                    manager.CheckForVergiNo(fb.VergiNumarası);
                    manager.Add(fb);
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("",ex.Message);
                }
                return RedirectToAction("Index", "FirmaBilgi");

            }
            return View();
        }
    }
}
