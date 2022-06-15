using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZiyaretciController : ControllerBase
    {
        private readonly IZiyaretciManager manager;

        public ZiyaretciController(IZiyaretciManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var ziyaretci = manager.GetAll(null);
            var jsonobject = new JsonResult(ziyaretci);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Ziyaretci Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(int firmaId, string yetkili, string unvani, string dahiliTelefon, string direktTelefon, string sektor)
        {
            Ziyaretci ziyaretci = new Ziyaretci();
            ziyaretci.FirmaId= firmaId;
            ziyaretci.Yetkili= yetkili;
            ziyaretci.Unvani= unvani;
            ziyaretci.DahiliTelefon= dahiliTelefon;
            ziyaretci.DirektTelefon= direktTelefon;
            ziyaretci.Sektor= sektor;
            manager.Add(ziyaretci);
            return Ok(ziyaretci);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Ziyaretci Updated(Ziyaretci zyaretci)
        {
            Ziyaretci updated = manager.Find(zyaretci.Id);
            updated.FirmaId=zyaretci.FirmaId;
            updated.Yetkili = zyaretci.Yetkili;
            updated.Unvani= zyaretci.Unvani;
            updated.DahiliTelefon= zyaretci.DahiliTelefon;
            updated.DirektTelefon= zyaretci.DirektTelefon;
            updated.Sektor= zyaretci.Sektor;
            manager.Update(updated);
            return updated;
        }
    }
}
