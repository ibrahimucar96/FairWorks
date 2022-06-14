using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaTipveTemsilEdilenFirmaController : ControllerBase
    {
        private readonly IFirmaTipveFirmaManager manager;
        private readonly FairWorksDbContext mn;

        public FirmaTipveTemsilEdilenFirmaController(IFirmaTipveFirmaManager manager,FairWorksDbContext mn)
        {
            this.manager = manager;
            this.mn = mn;
        }
        [HttpGet]
        public async Task<IActionResult> GetAction(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tef = await mn.FirmaTipiveFirmalar.Include(x=>x.FirmaTipi).Include(x=>x.TemsilEttigiFirma).FirstOrDefaultAsync(m=>m.TemsilEttigiFirmaId == id);
           
            if (tef == null)
            {
                return NotFound();
            }

            return Ok(tef);


        }

        [HttpPost("id")]
        public IActionResult Post(int temsilEttigiFirmaId,int firmaTipId)
        {
            FirmaTipveTemsilEdilenFirma tff = new FirmaTipveTemsilEdilenFirma();
            tff.TemsilEttigiFirmaId=temsilEttigiFirmaId;
            tff.FirmaTipId=firmaTipId;
            manager.Add(tff);
            return Ok(tff);
        }
    }    
}
