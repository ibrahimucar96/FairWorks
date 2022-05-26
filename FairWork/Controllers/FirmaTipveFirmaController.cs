using FairWorks.BLManager.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaTipveFirmaController : ControllerBase
    {
        private readonly IFirmaTipveFirmaManager manager;

        public FirmaTipveFirmaController(IFirmaTipveFirmaManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAllOrders(int TemsilEttigiFirmaId, string TemsilEdilenFirma, string Ulke, string TemsilEdilenFirmaUrunleri, string IletisimBilgileri, string FirmaTip)
        {
            var firmatipvetemsilettigifirma = manager.GetAllInclude
                   (x => x.TemsilEttigiFirmaId == TemsilEttigiFirmaId &&
                   x.TemsilEttigiFirma.TemsilEdilenFirma == TemsilEdilenFirma && x.TemsilEttigiFirma.Ulke == Ulke && x.TemsilEttigiFirma.TemsilEdilenFirmaUrunleri == TemsilEdilenFirmaUrunleri && x.TemsilEttigiFirma.IletisimBilgileri == IletisimBilgileri, x => x.FirmaTipi.FirmaTip == FirmaTip);
            return Ok(firmatipvetemsilettigifirma);
        }
    }
}
