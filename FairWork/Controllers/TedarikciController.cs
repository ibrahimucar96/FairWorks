using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TedarikciController : ControllerBase
    {
        private readonly ITedarikciManager manager;

        public TedarikciController(ITedarikciManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var tedarikci = manager.GetAll(null);
            var jsonobject = new JsonResult(tedarikci);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Tedarikci Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string tedarikciler)
        {
            Tedarikci tedarikci = new Tedarikci();
            tedarikci.Tedarikciler = tedarikciler;
            manager.Add(tedarikci);
            return Ok(tedarikci);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Tedarikci Updated(Tedarikci tdrkci)
        {
            Tedarikci updated = manager.Find(tdrkci.Id);
            updated.Tedarikciler= tdrkci.Tedarikciler;
            manager.Update(updated);
            return updated;
        }
    }
}
