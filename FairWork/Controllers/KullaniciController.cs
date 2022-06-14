using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciManager manager;

        public KullaniciController(IKullaniciManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var kullanici = manager.GetAll(null);
            var jsonobject = new JsonResult(kullanici);
            return jsonobject;
        }
        [HttpGet("{id}")]
        public Kullanici Get(int id)
        {
            return manager.Find(id);
        }
        [HttpPost]
        public IActionResult PostAction(string username, string password, string role)
        {
            Kullanici k = new Kullanici();
            k.UserName = username;
            k.Password = password;
            k.Role = role;
            manager.Add(k);
            return Ok(k);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIdAction(int id)
        {

            manager.Delete(id);
            return Ok();
        }
        [HttpPut]
        public Kullanici Updated(Kullanici kullanici)
        {
            Kullanici updated =manager.Find(kullanici.Id);
            updated.UserName = kullanici.UserName;
            updated.Password = kullanici.Password;
            updated.Role = kullanici.Role;
            manager.Update(updated);
            return updated;
        }
    }
}
