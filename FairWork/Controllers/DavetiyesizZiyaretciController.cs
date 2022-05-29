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
        public IActionResult PostAction(string Ad, string Soyad, int firma, string Meslek)
        {
            DavetiyesizZiyaretci davetiyesizZiyaretci = new DavetiyesizZiyaretci();
            davetiyesizZiyaretci.Ad = Ad;
            davetiyesizZiyaretci.SoyAd = Soyad;
            //davetiyesizZiyaretci.Firma = firma;
            davetiyesizZiyaretci.Meslek=Meslek;
            if (davetiyesizZiyaretci != null)
            {
                if (manager.Add(davetiyesizZiyaretci) > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            else
                return BadRequest();

        }
       
        [HttpDelete]
        public IActionResult DeleteId(int id)
        {
            var davetiyesiz= manager.Delete(id);
            return Ok();
        }
    }
}
