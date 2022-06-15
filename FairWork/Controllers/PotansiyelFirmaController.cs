using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotansiyelFirmaController : ControllerBase
    {
        private readonly IPotansiyelFirmaManager manager;

        public PotansiyelFirmaController(IPotansiyelFirmaManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var potansiyelFirma = manager.GetAll(null);
            var jsonobject = new JsonResult(potansiyelFirma);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public PotansiyelFirma Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string firmaAdı, string yetkili, string unvani, string telefon, string dahiliTelefon, string direktTelefon, string email, string faks, string adres, string ulke, string sehir, string sektor)
        {
            PotansiyelFirma pf = new PotansiyelFirma();
            pf.FirmaAdı = firmaAdı;
            pf.Yetkili = yetkili;
            pf.Unvani = unvani;
            pf.Telefon = telefon;
            pf.DahiliTelefon = dahiliTelefon;
            pf.DirektTelefon = direktTelefon;
            pf.Email = email;
            pf.Faks = faks;
            pf.Adres = adres;
            pf.Ulke = ulke;
            pf.Sehir = sehir;
            pf.Sektor = sektor;
            manager.Add(pf);
            return Ok(pf);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public PotansiyelFirma Updated(PotansiyelFirma potansiyelFirma)
        {
            PotansiyelFirma updated = manager.Find(potansiyelFirma.Id);
            updated.FirmaAdı = potansiyelFirma.FirmaAdı;
            updated.Yetkili= potansiyelFirma.Yetkili;
            updated.Unvani = potansiyelFirma.Unvani;
            updated.Telefon = potansiyelFirma.Telefon;
            updated.DahiliTelefon = potansiyelFirma.DahiliTelefon;
            updated.DirektTelefon = potansiyelFirma.DirektTelefon;
            updated.Email= potansiyelFirma.Email;
            updated.Faks=potansiyelFirma.Faks;
            updated.Adres = potansiyelFirma.Adres;
            updated.Ulke= potansiyelFirma.Ulke;
            updated.Sehir = potansiyelFirma.Sehir;
            updated.Sektor = potansiyelFirma.Sektor;
            manager.Update(updated);
            return updated;
        }
    }
}
