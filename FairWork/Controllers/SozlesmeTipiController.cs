using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SozlesmeTipiController : ControllerBase
    {
        private readonly ISozlesmeTipiManager manager;

        public SozlesmeTipiController(ISozlesmeTipiManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var st = manager.GetAll(null);
            var jsonobject = new JsonResult(st);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public SozlesmeTipi Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string sozlesmeTipleri)
        {
            SozlesmeTipi st = new SozlesmeTipi();
            st.SozlesmeTipleri = sozlesmeTipleri;
            manager.Add(st);
            return Ok(st);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public SozlesmeTipi Updated(SozlesmeTipi st)
        {
            SozlesmeTipi updated = manager.Find(st.Id);
            updated.SozlesmeTipleri=st.SozlesmeTipleri;
            manager.Update(updated);
            return updated;
        }
    }
}
