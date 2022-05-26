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
        [HttpPost]
        public IActionResult PostAction(int firmaid, string firmaAd, string adres, string telefon, string eposta, string faks, string ulke, string sehir)
        {
            Firma firma = new Firma();
            firma.FirmaId= firmaid;
            firma.FirmaAd= firmaAd;
            firma.Adres= adres;
            firma.Telefon= telefon;
            firma.Eposta= eposta;
            firma.Faks= faks;
            firma.Ulke= ulke;
            firma.Sehir= sehir;
            if (firma != null)
            {
                if (manager.Add(firma) > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            else
                return BadRequest();
        }
        [HttpDelete]
        public IActionResult DeleteAction(Firma firma)
        {
            if (firma != null)
            {
                manager.Delete(firma);
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
