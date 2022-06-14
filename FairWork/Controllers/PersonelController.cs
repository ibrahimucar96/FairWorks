using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private readonly IPersonelManager manager;

        public PersonelController(IPersonelManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var personel = manager.GetAll(null);
            var jsonobject = new JsonResult(personel);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Personel Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string ad, string soyAd, string tcNo, string email, string unvan, DateTime birthdate, string adres, string sehir, string bolge, string ulke, string telefon, string not, string raporVerdigiKisi, decimal maas)
        {
            Personel p = new Personel();
            p.Ad = ad;
            p.SoyAd = soyAd;
            p.TcNo = tcNo;
            p.Email = email;
            p.Unvan = unvan;
            p.BirthDate = birthdate;
            p.Adres = adres;
            p.Sehir = sehir;
            p.Bolge = bolge;
            p.Ulke = ulke;
            p.Telefon= telefon;
            p.Notlar = not;
            p.RaporVerdigiKisi = raporVerdigiKisi;
            p.Maas = maas;
            manager.Add(p);
            return Ok(p);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Personel Updated(Personel personel)
        {
            Personel updated = manager.Find(personel.Id);
            updated.Ad=personel.Ad;
            updated.SoyAd=personel.SoyAd;
            updated.TcNo=personel.TcNo;
            updated.Email=personel.Email;
            updated.Unvan=personel.Unvan;
            updated.BirthDate=personel.BirthDate;
            updated.Adres=personel.Adres;
            updated.Sehir=personel.Sehir;
            updated.Bolge=personel.Bolge;
            updated.Ulke=personel.Ulke;
            updated.Telefon=personel.Telefon;
            updated.Notlar=personel.Notlar;
            updated.RaporVerdigiKisi=personel.RaporVerdigiKisi;
            updated.Maas=personel.Maas;
            manager.Update(updated);
            return updated;
        }
    }
}
