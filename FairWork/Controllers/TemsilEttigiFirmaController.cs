using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemsilEttigiFirmaController : ControllerBase
    {
        private readonly ITemsilEttigiFirmaManager manager;

        public TemsilEttigiFirmaController(ITemsilEttigiFirmaManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var temsilettigifirma = manager.GetAll(null);
            var jsonobject = new JsonResult(temsilettigifirma);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public TemsilEttigiFirma Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string temsiledilenfirma, string ulke, string temsiledilenfirmaurunleri, string ıletisimbilgileri)
        {
            TemsilEttigiFirma tef = new TemsilEttigiFirma();
            tef.TemsilEdilenFirma = temsiledilenfirma;
            tef.Ulke = ulke;
            tef.TemsilEdilenFirmaUrunleri = temsiledilenfirmaurunleri;
            tef.IletisimBilgileri = ıletisimbilgileri;
            manager.Add(tef);
            return Ok(tef);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public TemsilEttigiFirma Update(TemsilEttigiFirma temsilettigifirma)
        {
            TemsilEttigiFirma updated = manager.Find(temsilettigifirma.TemsilEttigiFirmaId);
            updated.TemsilEdilenFirma = temsilettigifirma.TemsilEdilenFirma;
            updated.Ulke = temsilettigifirma.Ulke;
            updated.TemsilEdilenFirmaUrunleri = temsilettigifirma.TemsilEdilenFirmaUrunleri;
            updated.IletisimBilgileri = temsilettigifirma.IletisimBilgileri;
            manager.Update(updated);
            return updated;
        }
    }
}
