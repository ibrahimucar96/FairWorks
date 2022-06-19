using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.DAL.EFCore;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaBilgiController : Controller
    {
        private readonly IFirmaBilgiManager manager;
        private readonly IMapper mapper;

        public FirmaBilgiController(IFirmaBilgiManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var firmaBilgi = manager.GetAll(null);
            return View(firmaBilgi);
            
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            FirmaBilgiDto entity = new FirmaBilgiDto();


            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(FirmaBilgiDto firmaBilgi)
        {
            if (ModelState.IsValid)
            {
                var fb = mapper.Map<FirmaBilgiDto, FirmaBilgi>(firmaBilgi);
                manager.Add(fb);
                return RedirectToAction("Index", "FirmaBilgi");

            }
            return View();
        }
    }
}
