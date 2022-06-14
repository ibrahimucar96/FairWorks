using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KatalogGirisFormController : ControllerBase
    {
        private readonly IKatalogGirisFormManager manager;
       

        public KatalogGirisFormController(IKatalogGirisFormManager manager)
        {
            this.manager = manager;
            
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var katalogGirisForm = manager.GetAll(null);
            var jsonobject = new JsonResult(katalogGirisForm);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public KatalogGirisForm Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(int firmaId, int urunId,  int firmatipId)
        {
            KatalogGirisForm form = new KatalogGirisForm();
            form.FirmaId = firmaId;            
            form.UrunId= urunId;           
            form.FirmaTipId = firmatipId;            
            manager.Add(form);
            return Ok(form);
        }
    }
}
