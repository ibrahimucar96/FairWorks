using AutoMapper;
using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TemsilEttigiFirmaController : Controller
    {
        private readonly ITemsilEttigiFirmaManager manager;
        private readonly IMapper mapper;

        public TemsilEttigiFirmaController(ITemsilEttigiFirmaManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var temsilEttigiFirma = manager.GetAll(null);
            return View(temsilEttigiFirma);
        }
    }
}
