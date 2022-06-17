using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    [Authorize(Roles = "Employee,Admin")]
    public class DavetiyesizZiyaretciController : Controller
    {
        private readonly IDavetiyesizZiyaretciManager manager;

        public DavetiyesizZiyaretciController(IDavetiyesizZiyaretciManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var davetiyesiz = manager.GetAll(null);
            return View(davetiyesiz);
        }
    }
}
