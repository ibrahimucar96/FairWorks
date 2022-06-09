using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DovizController : ControllerBase
    {
        private readonly IDovizManager manager;

        public DovizController(IDovizManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var doviz = manager.GetAll(null);
            var jsonobject = new JsonResult(doviz);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Doviz Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string dovizcinsi,decimal dovizkuru)
        {
            Doviz doviz = new Doviz();
            doviz.DovizKuru = dovizkuru;
            doviz.DovizCinsi = dovizcinsi;
            manager.Add(doviz);
            return Ok(doviz);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Doviz Update(Doviz dvz)
        {
            Doviz updated = manager.Find(dvz.Id);
            updated.DovizCinsi=dvz.DovizCinsi;
            updated.DovizKuru=dvz.DovizKuru;
            manager.Update(updated);
            return updated;
        }
    }
}
