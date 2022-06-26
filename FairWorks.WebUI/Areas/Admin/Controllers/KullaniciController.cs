﻿using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class KullaniciController : Controller
    {
        private readonly IKullaniciManager us;
        private readonly IMapper mapper;
        

        public KullaniciController(IKullaniciManager us, IMapper mapper)
        {
            this.us = us;
            this.mapper = mapper;
            
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(us.GetAll(null));
        }
        [AllowAnonymous]
        public IActionResult Create()
        {
            LoginCreateDto entity = new LoginCreateDto();


            return View(entity);          
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create(LoginCreateDto k)
        {
            if (ModelState.IsValid)
            {
                var kullanici = mapper.Map<LoginCreateDto, Kullanici>(k);
                us.Add(kullanici);
                return RedirectToAction("Index", "Kullanici");

            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var entity = us.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Kullanici user)
        {
            if (ModelState.IsValid)
            {
                us.Update(user);
                return RedirectToAction("Index", "Kullanici");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = us.Find(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Kullanici user)
        {
            us.Delete(user);
            return RedirectToAction("Index", "Kullanici");

        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
