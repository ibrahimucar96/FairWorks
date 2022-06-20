using AutoMapper;
using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Mvc;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;
using Microsoft.AspNetCore.Authorization;

namespace FairWorks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FirmaTipiController : Controller
    {
        private readonly IFirmaTipiManager manager;
        private readonly IMapper mapper;

        public FirmaTipiController(IFirmaTipiManager manager,IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var frmaTipi = manager.GetAll(null);
            return View(frmaTipi);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FirmaTipiDto entity = new FirmaTipiDto();
            return View(entity);
        }
        [HttpPost]
        public IActionResult Create(FirmaTipiDto ftd)
        {
            if (ModelState.IsValid)
            {
                var firmaTipi = mapper.Map<FirmaTipiDto, FirmaTipi>(ftd);
                manager.Add(firmaTipi);
                return RedirectToAction("Index","FirmaTipi");
            }
            return View();
        }
    }
}
