using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeklifBilgisiController : ControllerBase
    {
        private readonly ITeklifBilgisiManager manager;

        public TeklifBilgisiController(ITeklifBilgisiManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var teklif = manager.GetAll(null);
            var jsonobject = new JsonResult(teklif);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public TeklifBilgisi Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(DateTime teklifTarihi, decimal teklifVerilenm2, decimal m2birimFiyati, int standId, int dovizId, int odemePlaniId, int salonId, DateTime teklifinSonGecerlilikTarihi)
        {
            TeklifBilgisi tb = new TeklifBilgisi();
            tb.TeklifTarihi=teklifTarihi;
            tb.TeklifVerilenm2=teklifVerilenm2;
            tb.m2birimFiyatı = m2birimFiyati;
            tb.StandId=standId;
            tb.DovizId=dovizId;
            tb.OdemePlaniId=odemePlaniId;
            tb.salonId=salonId;
            tb.TeklifinSonGecerlilikTarihi = teklifinSonGecerlilikTarihi;
            manager.Add(tb);
            return Ok(tb);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public TeklifBilgisi Updated(TeklifBilgisi teklifBilgisi)
        {
            TeklifBilgisi updated = manager.Find(teklifBilgisi.Id);
            updated.TeklifTarihi= teklifBilgisi.TeklifTarihi;
            updated.TeklifVerilenm2 = teklifBilgisi.TeklifVerilenm2;
            updated.m2birimFiyatı = teklifBilgisi.m2birimFiyatı;
            updated.StandId=teklifBilgisi.StandId;
            updated.DovizId=teklifBilgisi.DovizId;
            updated.OdemePlaniId=teklifBilgisi.OdemePlaniId;
            updated.salonId = teklifBilgisi.salonId;
            updated.TeklifinSonGecerlilikTarihi = teklifBilgisi.TeklifinSonGecerlilikTarihi;
            manager.Update(updated);
            return updated;
        }
    }
}
