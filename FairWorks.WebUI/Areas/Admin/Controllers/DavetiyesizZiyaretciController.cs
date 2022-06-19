using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Mvc;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DavetiyesizZiyaretciController : Controller
    {
        private readonly IDavetiyesizZiyaretciManager manager;

        public DavetiyesizZiyaretciController(IDavetiyesizZiyaretciManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var davetiyesizZiyaretci = manager.GetAll(null);
            return View(davetiyesizZiyaretci);
        }
        [HttpGet]
        public IActionResult Create()
        {
            DavetiyesizZiyaretci entity = new DavetiyesizZiyaretci();


            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(DavetiyesizZiyaretci dz)
        {
            if (ModelState.IsValid)
            {
                manager.Add(dz);
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
