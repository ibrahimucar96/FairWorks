using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaController : Controller
    {
        private readonly IFirmaManager manager;

        public FirmaController(IFirmaManager manager)
        {
            this.manager = manager;
        }
       
        public IActionResult Index()
        {
            var firma = manager.GetAll(null);
            return View(firma);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Firma entity = new Firma();


            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(Firma firma)
        {
            if (ModelState.IsValid)
            {
                manager.Add(firma);
                return RedirectToAction("Index", "Firma");

            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var entity = manager.Find(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Firma firma)
        {
            if (ModelState.IsValid)
            {
                manager.Update(firma);
                return RedirectToAction("Index", "Firma");
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
        public IActionResult Delete(Firma firma)
        {
            manager.Delete(firma);
            return RedirectToAction("Index", "Firma");
        }
    }
}
