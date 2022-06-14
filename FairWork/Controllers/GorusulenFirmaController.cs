using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GorusulenFirmaController : ControllerBase
    {
        private readonly IGorusulenFirmaManager manager;

        public GorusulenFirmaController(IGorusulenFirmaManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var gorusulenfirma = manager.GetAll(null);
            var jsonobject = new JsonResult(gorusulenfirma);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public GorusulenFirma Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(int personelId,DateTime gorusmeTarihi,string gorusulenKisi,string unvani,string telefon,string eposta,string firmaninCalistigiSektoru,string firmaninProfili,string firmaninIlgilendigiFuar,string firmaninIlgilendigiSalon,string gorusmeNotlari)
        {
            GorusulenFirma gf = new GorusulenFirma();
            gf.PersonelId = personelId;
            gf.GorusmeTarihi = gorusmeTarihi;
            gf.GorusulenKisi = gorusulenKisi;
            gf.Unvanı=unvani;
            gf.Telefon = telefon;
            gf.Eposta = eposta;
            gf.FirmanınCalıstıgıSektoru = firmaninCalistigiSektoru;
            gf.FirmaninProfili = firmaninProfili;
            gf.FirmaninIlgilendigiFuar = firmaninIlgilendigiFuar;
            gf.FirmaninIlgilendigiSalon = firmaninIlgilendigiSalon;
            gf.GorusmeNotlari = gorusmeNotlari;
            manager.Add(gf);
            return Ok(gf);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public GorusulenFirma Update(GorusulenFirma gorusulenFirma)
        {
            GorusulenFirma updated = manager.Find(gorusulenFirma.Id);
            updated.PersonelId = gorusulenFirma.PersonelId;
            updated.GorusmeTarihi = gorusulenFirma.GorusmeTarihi;
            updated.GorusulenKisi = gorusulenFirma.GorusulenKisi;
            updated.Unvanı = gorusulenFirma.Unvanı;
            updated.Telefon=gorusulenFirma.Telefon;
            updated.Eposta = gorusulenFirma.Eposta;
            updated.FirmanınCalıstıgıSektoru = gorusulenFirma.FirmanınCalıstıgıSektoru;
            updated.FirmaninProfili = gorusulenFirma.FirmaninProfili;
            updated.FirmaninIlgilendigiFuar = gorusulenFirma.FirmaninIlgilendigiFuar;
            updated.FirmaninIlgilendigiSalon = gorusulenFirma.FirmaninIlgilendigiSalon;
            updated.GorusmeNotlari = gorusulenFirma.GorusmeNotlari;
            manager.Update(updated);
            return updated;
        }
    }
}
