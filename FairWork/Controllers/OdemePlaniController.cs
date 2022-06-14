using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdemePlaniController : ControllerBase
    {
        private readonly IOdemePlaniManager manager;

        public OdemePlaniController(IOdemePlaniManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var odeme = manager.GetAll(null);
            var jsonobject = new JsonResult(odeme);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public OdemePlani Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(decimal vadeSayisi, int taksit, decimal faiz, string ay, string yil, decimal m2birimFiyati, decimal m2, decimal indirimOrani)
        {
            OdemePlani odemePlani = new OdemePlani();
            odemePlani.VadeSayisi = vadeSayisi;
            odemePlani.Taksit = taksit;
            odemePlani.Faiz = faiz;
            odemePlani.Ay = ay;
            odemePlani.Yıl = yil;
            odemePlani.m2BirimFiyati = m2birimFiyati;
            odemePlani.m2 = m2;
            odemePlani.indirimOrani = indirimOrani;
            manager.Add(odemePlani);
            return Ok(odemePlani);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public OdemePlani Updated(OdemePlani op)
        {
            OdemePlani updated = manager.Find(op.Id);
            updated.VadeSayisi = op.VadeSayisi;
            updated.Taksit = op.Taksit;
            updated.Faiz = op.Faiz;
            updated.Ay = op.Ay;
            updated.Yıl = op.Yıl;
            updated.m2BirimFiyati = op.m2BirimFiyati;
            updated.m2 = op.m2;
            updated.indirimOrani = op.indirimOrani;
            manager.Update(updated);
            return updated;
        }
    }
}
