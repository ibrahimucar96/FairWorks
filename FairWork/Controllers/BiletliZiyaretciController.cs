using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace FairWorks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BiletliZiyaretciController : ControllerBase
    {
        private readonly IBiletliZiyaretciManager manager;

        public BiletliZiyaretciController(IBiletliZiyaretciManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public IActionResult GetAction()
        {
            var biletliziyaretci = manager.GetAll(null);
            var jsonobject = new JsonResult(biletliziyaretci);
            return jsonobject;




        }
        [HttpPost]
        public IActionResult PostAction(string Ad, string Soyad, string firmaAd, string adres, string telefon, string eposta, string faks, string Meslek)
        {
            BiletliZiyaretci biletliziyaretci = new BiletliZiyaretci();
            biletliziyaretci.Ad = Ad;
            biletliziyaretci.SoyAd = Soyad;
            biletliziyaretci.FirmaAdı = firmaAd;
            biletliziyaretci.Adres = adres;
            biletliziyaretci.Telefon = telefon;
            biletliziyaretci.Eposta = eposta;
            biletliziyaretci.Faks = faks;
            biletliziyaretci.Meslek = Meslek;
            if (biletliziyaretci != null)
            {
                if (manager.Add(biletliziyaretci) > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            else
                return BadRequest();

        }
        [HttpDelete]
        public IActionResult DeleteAction(BiletliZiyaretci biletliziyaretci)
        {
            if (biletliziyaretci != null)
            {
                manager.Delete(biletliziyaretci);
                return Ok();
            }
            else
                return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
    }
}
