using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlaveStandMalzemelerController : ControllerBase
    {
        private readonly IIlaveStandMalzemeleriManager manager;

        public IlaveStandMalzemelerController(IIlaveStandMalzemeleriManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var ilavestandmalzeme = manager.GetAll(null);
            var jsonobject = new JsonResult(ilavestandmalzeme);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public IlaveStandMalzemeler Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string ilaveStandMalzemesi, int malzemeKodu, string malzemeAdı, string elektrikKw, decimal fiyat, string ozellik, int tedarikciId)
        {
            IlaveStandMalzemeler ism = new IlaveStandMalzemeler();
            ism.IlaveStandMalzemesi = ilaveStandMalzemesi;
            ism.MalzemeKodu = malzemeKodu;
            ism.MalzemeleAdı = malzemeAdı;
            ism.ElektrikKw = elektrikKw;
            ism.Fiyat = fiyat;
            ism.Ozellik = ozellik;
            ism.TedarikciId = tedarikciId;
            manager.Add(ism);
            return Ok(ism);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IlaveStandMalzemeler Updated(IlaveStandMalzemeler ilaveStandMalzemeler)
        {
            IlaveStandMalzemeler updated = manager.Find(ilaveStandMalzemeler.Id);
            updated.IlaveStandMalzemesi = ilaveStandMalzemeler.IlaveStandMalzemesi;
            updated.MalzemeKodu = ilaveStandMalzemeler.MalzemeKodu;
            updated.MalzemeleAdı = ilaveStandMalzemeler.MalzemeleAdı;
            updated.ElektrikKw = ilaveStandMalzemeler.ElektrikKw;
            updated.Fiyat=ilaveStandMalzemeler.Fiyat;
            updated.Ozellik = ilaveStandMalzemeler.Ozellik;
            updated.TedarikciId = ilaveStandMalzemeler.TedarikciId;
            manager.Update(updated);
            return updated;
        }
    }
}
