﻿using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class IlaveStandMalzemelerController : Controller
    {
        private readonly IIlaveStandMalzemeleriManager manager;
        private readonly IMapper mapper;
        private readonly ITedarikciManager tedarikci;

        public IlaveStandMalzemelerController(IIlaveStandMalzemeleriManager manager,IMapper mapper,ITedarikciManager tedarikci)
        {
            this.manager = manager;
            this.mapper = mapper;
            this.tedarikci = tedarikci;
        }
        public IActionResult Index()
        {
            List<IlaveStandMalzemeler> malzeme = new List<IlaveStandMalzemeler>();
            malzeme = manager.GetAll(null);


            if (malzeme.Count == 0)
                malzeme.Add(new IlaveStandMalzemeler());

            return View(malzeme);
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            var malzeme = new IlaveStandMalzemelerCreateDto();
            var tedarik = tedarikci.GetAll(null);
            List<TedarikciModel> tedarikSelectList = new();
            foreach (var item in tedarik)
            {
                tedarikSelectList.Add(new TedarikciModel { Id = item.Id, Tedarikciler = item.Tedarikciler });
            }
            ViewBag.Tedarikci = new SelectList(tedarikSelectList, "Id", "Tedarikciler");
            return View(malzeme);
        }
        [HttpPost]
        public IActionResult Create(IlaveStandMalzemelerCreateDto malzeme)
        {
            if (ModelState.IsValid)
            {
                var mlzme = mapper.Map<IlaveStandMalzemelerCreateDto, IlaveStandMalzemeler>(malzeme);               ;
                manager.Add(mlzme);
                return RedirectToAction("Index", "IlaveStandMalzemeler", new { Areas = "Admin" });
            }
            return View(malzeme);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var malzeme = manager.Find(id);
            var updateDto = mapper.Map<IlaveStandMalzemeler, IlaveStandMalzemelerCreateDto>(malzeme);

            var tedarik = tedarikci.GetAll(null);
            List<TedarikciModel> tedarikciModel = new();
            foreach (var item in tedarik)
            {
                tedarikciModel.Add(new TedarikciModel { Id = item.Id, Tedarikciler = item.Tedarikciler });
            }
            var tedarikciSelectList = new SelectList(tedarikciModel, "Id", "Tedarikciler");
            ViewBag.Tedarikci = tedarikciSelectList;
            return View(updateDto);
        }
        [HttpPost]
        public IActionResult Update(IlaveStandMalzemelerCreateDto update)
        {
            if (ModelState.IsValid)
            {
                var malzeme = mapper.Map<IlaveStandMalzemelerCreateDto, IlaveStandMalzemeler>(update);
               

                    manager.Update(malzeme);
                    return RedirectToAction("Index", "IlaveStandMalzemeler");               
            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            var values = manager.Find(id);
            manager.Delete(values);
            return RedirectToAction("Index", "IlaveStandMalzemeler");
        }
    }
}
