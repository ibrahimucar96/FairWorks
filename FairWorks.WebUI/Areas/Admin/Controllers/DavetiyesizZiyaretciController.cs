using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Mvc;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using FairWorks.WebUI.Areas.Admin.Models.Dto;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DavetiyesizZiyaretciController : Controller
    {
        private readonly IDavetiyesizZiyaretciManager manager;
        private readonly IMapper mapper;

        public DavetiyesizZiyaretciController(IDavetiyesizZiyaretciManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var davetiyesizZiyaretci = manager.GetAll(null);
            return View(davetiyesizZiyaretci);
        }
        [HttpGet]
        public IActionResult Create()
        {
            DavetiyesizZiyaretciDto entity = new DavetiyesizZiyaretciDto();


            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(DavetiyesizZiyaretciDto dz)
        {
            if (ModelState.IsValid)
            {
                var davetiyesizZiyaretci = mapper.Map<DavetiyesizZiyaretciDto, DavetiyesizZiyaretci>(dz);
                manager.Add(davetiyesizZiyaretci);
                return RedirectToAction("Index", "DavetiyesizZiyaretci");

            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(DavetiyesizZiyaretci davetiyesizZiyaretci)
        {
            if (ModelState.IsValid)
            {
                manager.Update(davetiyesizZiyaretci);
                return RedirectToAction("Index", "DavetiyesizZiyaretci");
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
        public IActionResult Delete(DavetiyesizZiyaretci dz)
        {
            manager.Delete(dz);
            return RedirectToAction("Index", "DavetiyesizZiyaretci");
        }
    }
}
