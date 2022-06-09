using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavetiyesizZiyaretciController : ControllerBase
    {
        private readonly IDavetiyesizZiyaretciManager manager;

        public DavetiyesizZiyaretciController(IDavetiyesizZiyaretciManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var davetiyesizZiyaretci = manager.GetAll(null);
            var jsonobject = new JsonResult(davetiyesizZiyaretci);
            return jsonobject;
        }
        [HttpPost]
        public IActionResult PostAction(string Ad, string Soyad, string firmaAd,string telefon,string eposta,string faks, string Meslek)
        {
            DavetiyesizZiyaretci davetiyesizZiyaretci = new DavetiyesizZiyaretci();
            davetiyesizZiyaretci.Ad = Ad;
            davetiyesizZiyaretci.SoyAd = Soyad;
            davetiyesizZiyaretci.FirmaAdı = firmaAd;
            davetiyesizZiyaretci.Telefon= telefon;
            davetiyesizZiyaretci.Eposta= eposta;
            davetiyesizZiyaretci.Faks= faks;
            davetiyesizZiyaretci.Meslek=Meslek;

           manager.Add(davetiyesizZiyaretci);
            

            return Ok(davetiyesizZiyaretci);
            
            

        }
        [HttpGet("{id}")]
        public DavetiyesizZiyaretci Get(int id)
        {
            return manager.Find(id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteId(int id)
        {
            var davetiyesiz= manager.Delete(id);
            return Ok();
        }
    }
}
