using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UcretsizVerilenAlanController : Controller
    {
        private readonly IUcretsizVerilenAlanManager manager;

        public UcretsizVerilenAlanController(IUcretsizVerilenAlanManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var alan = manager.GetAll(null);
            return View(alan);
        }
        [HttpGet]
        public IActionResult Create()
        {
            UcretsizVerilenAlan ucretsizVerilenAlan = new UcretsizVerilenAlan();

            return View(ucretsizVerilenAlan);
        }
        [HttpPost]
        public IActionResult Create(UcretsizVerilenAlan uva)
        {
            if (ModelState.IsValid)
            {
                manager.Add(uva);
                return RedirectToAction("Index", "UcretsizVerilenAlan");
            }

            return View(uva);
        }
    }
}
