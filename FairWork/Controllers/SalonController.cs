using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonController : ControllerBase
    {
        private readonly ISalonManager manager;

        public SalonController(ISalonManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var salon = manager.GetAll(null);
            var jsonobject = new JsonResult(salon);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Salon Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string ulke, string sehir, int salonNo, string m2, string en, string boy, string sektorAdi)
        {
            Salon salon = new Salon();
            salon.Ulke = ulke;
            salon.Sehir = sehir;
            salon.SalonNo = salonNo;
            salon.m2 = m2;
            salon.en = en;
            salon.boy = boy;
            salon.SektorAdi = sektorAdi;
            manager.Add(salon);
            return Ok(salon);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Salon Updated(Salon salon)
        {
            Salon updated = manager.Find(salon.Id);
            updated.Ulke = salon.Ulke;
            updated.Sehir = salon.Sehir;
            updated.SalonNo = salon.SalonNo;
            updated.m2 = salon.m2;
            updated.en=salon.en;
            updated.boy = salon.boy;
            updated.SektorAdi = salon.SektorAdi;
            manager.Update(updated);
            return updated;
        }
    }
}
