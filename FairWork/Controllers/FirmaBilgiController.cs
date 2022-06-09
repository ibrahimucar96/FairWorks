using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaBilgiController : ControllerBase
    {
        private readonly IFirmaBilgiManager manager;
        

        public FirmaBilgiController(IFirmaBilgiManager manager)
        {
            this.manager = manager;
            
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var firmabilgi = manager.GetAll(null);
            var jsonobject = new JsonResult(firmabilgi);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public FirmaBilgi Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string adres,string telefon,string vergidairesi,string vergino,string fuaryetkilisi)
        {
            FirmaBilgi firmabilgi = new FirmaBilgi();
            firmabilgi.Adres = adres;
            firmabilgi.Telefon = telefon;
            firmabilgi.VergiDairesi = vergidairesi;
            firmabilgi.VergiNumarası = vergino;
            firmabilgi.FuarYetkilisi = fuaryetkilisi;
            manager.Add(firmabilgi);
            return Ok(firmabilgi);                                               
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public FirmaBilgi Update(FirmaBilgi firmabilgi)
        {
            FirmaBilgi updated = manager.Find(firmabilgi.Id);
            updated.Adres= firmabilgi.Adres;
            updated.Telefon = firmabilgi.Telefon;
            updated.VergiDairesi = firmabilgi.VergiDairesi;
            updated.VergiNumarası = firmabilgi.VergiNumarası;
            updated.FuarYetkilisi = firmabilgi.FuarYetkilisi;
            manager.Update(updated);
            return updated;
               
        }
    }
}
