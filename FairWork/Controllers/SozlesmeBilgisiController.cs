using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SozlesmeBilgisiController : ControllerBase
    {
        private readonly ISozlesmeBilgisiManager manager;

        public SozlesmeBilgisiController(ISozlesmeBilgisiManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var sb = manager.GetAll(null);
            var jsonobject = new JsonResult(sb);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public SozlesmeBilgisi Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(int personelId, int firmaBilgileriId, int sozlesmeTipiId, int salonId, int standId, int odemePlaniId, string dovizCinsi, decimal dovizKuru, DateTime sozlesmeSonGecerlilikTarihi, bool imzaliSozlesmeDurumu)
        {
            SozlesmeBilgisi sb = new SozlesmeBilgisi();
            sb.PersonelId = personelId;
            sb.FirmaBilgileriId = firmaBilgileriId;
            sb.SozlesmeTipiId = sozlesmeTipiId;
            sb.salonId = salonId;
            sb.StandId=standId;
            sb.OdemePlaniId= odemePlaniId;
            sb.DovizCinsi = dovizCinsi;
            sb.DovizKuru = dovizKuru;
            sb.SozlesmeSonGecerlilikTarihi = sozlesmeSonGecerlilikTarihi;
            sb.ImzaliSozlesmeDurumu = imzaliSozlesmeDurumu;
            manager.Add(sb);
            return Ok(sb);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public SozlesmeBilgisi Updated(SozlesmeBilgisi sozlesmeBilgisi)
        {
            SozlesmeBilgisi updated = manager.Find(sozlesmeBilgisi.Id);
            updated.PersonelId = sozlesmeBilgisi.PersonelId;
            updated.FirmaBilgileriId= sozlesmeBilgisi.FirmaBilgileriId;
            updated.SozlesmeTipiId= sozlesmeBilgisi.SozlesmeTipiId;
            updated.salonId = sozlesmeBilgisi.salonId;
            updated.StandId= sozlesmeBilgisi.StandId;
            updated.OdemePlaniId= sozlesmeBilgisi.OdemePlaniId;
            updated.DovizCinsi = sozlesmeBilgisi.DovizCinsi;
            updated.DovizKuru= sozlesmeBilgisi.DovizKuru;
            updated.SozlesmeSonGecerlilikTarihi = sozlesmeBilgisi.SozlesmeSonGecerlilikTarihi;
            updated.ImzaliSozlesmeDurumu= sozlesmeBilgisi.ImzaliSozlesmeDurumu;
            manager.Update(updated);
            return updated;
        }
    }
}
