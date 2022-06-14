using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaTipController : ControllerBase
    {
        private readonly IFirmaTipiManager manager;

        public FirmaTipController(IFirmaTipiManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var firmatip = manager.GetAll(null);
            var jsonobject = new JsonResult(firmatip);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public FirmaTipi Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string firmatip)
        {
            FirmaTipi firmaTipi = new FirmaTipi();
            firmaTipi.FirmaTip = firmatip;
            manager.Add(firmaTipi);
            return Ok(firmaTipi);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public FirmaTipi Update(FirmaTipi firmatipi)
        {
            FirmaTipi updated = manager.Find(firmatipi.FirmaTipId);
            updated.FirmaTip = firmatipi.FirmaTip;
            manager.Update(updated);
            return updated;
        }

    }
}
