using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandController : ControllerBase
    {
        private readonly IStandManager manager;

        public StandController(IStandManager manager)
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
        public Stand Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string standTipi, int standKodu, int salonId)
        {
            Stand stand = new Stand();
            stand.StandTipi = standTipi;
            stand.StandKodu = standKodu;
            stand.SalonId = salonId;
            manager.Add(stand);
            return Ok(stand);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Stand Updated(Stand stand)
        {
            Stand updated = manager.Find(stand.Id);
            updated.StandTipi=stand.StandTipi;
            updated.StandKodu=stand.StandKodu;
            updated.SalonId=stand.SalonId;
            manager.Update(updated);
            return updated;
        }
    }
}
