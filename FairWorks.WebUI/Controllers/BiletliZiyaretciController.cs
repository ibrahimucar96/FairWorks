using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    public class BiletliZiyaretciController : Controller
    {
        private readonly IBiletliZiyaretciManager manager;

        public BiletliZiyaretciController(IBiletliZiyaretciManager manager)
        {
            ;
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var biletliZiyaretci = manager.GetAll(null);
            return View(biletliZiyaretci);
        }
    }
}
