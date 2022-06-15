using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunManager manager;

        public UrunController(IUrunManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var urun = manager.GetAll(null);
            var jsonobject = new JsonResult(urun);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Urun Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string urunAdi, int adet, decimal fiyat, int urunKodu, string urunBilgileri)
        {
            Urun urun = new Urun();
            urun.UrunAdi = urunAdi;
            urun.Adet = adet;
            urun.Fiyat = fiyat;
            urun.UrunKodu=urunKodu;
            urun.UrunBilgileri = urunBilgileri;
            manager.Add(urun);
            return Ok(urun);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Urun Updated(Urun urn)
        {
            Urun updated = manager.Find(urn.Id);
            updated.UrunAdi=urn.UrunAdi;
            updated.Adet= urn.Adet;
            updated.Fiyat= urn.Fiyat;
            updated.UrunKodu= urn.UrunKodu;
            updated.UrunBilgileri= urn.UrunBilgileri;
            manager.Update(updated);
            return updated;
        }
    }
}
