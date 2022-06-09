using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaManager manager;

        public FirmaController(IFirmaManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var firma = manager.GetAll(null);
            var jsonobject = new JsonResult(firma);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Firma Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction( string firmaAd, string adres, string telefon, string eposta, string faks, string ulke, string sehir)
        {
            Firma firma = new Firma();
            
            firma.FirmaAd= firmaAd;
            firma.Adres= adres;
            firma.Telefon= telefon;
            firma.Eposta= eposta;
            firma.Faks= faks;
            firma.Ulke= ulke;
            firma.Sehir= sehir;
            manager.Add(firma);
            return Ok(firma);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Firma Update(Firma firma)
        {
            Firma updated = manager.Find(firma.Id);
            updated.FirmaAd = firma.FirmaAd;
            updated.Adres= firma.Adres;
            updated.Telefon= firma.Telefon;
            updated.Eposta= firma.Eposta;
            updated.Faks= firma.Faks;
            updated.Ulke= firma.Ulke;
            updated.Sehir= firma.Sehir;
            manager.Update(updated);

            return updated;
        }
    }
}
