using AutoMapper;
using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Models.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Controllers
{
    
    public class KullaniciController : Controller
    {
        private readonly IKullaniciManager manager;
        private readonly FairWorksDbContext db;
        private readonly IMapper mapper;

        public KullaniciController(IKullaniciManager manager,FairWorksDbContext db,IMapper mapper)
        {
            this.manager = manager;
            this.db = db;
            this.mapper = mapper;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var kullanicilar = manager.GetAll(null);
            return View(kullanicilar);
        }
        [AllowAnonymous]
        public IActionResult Giris()
        {
            LoginDto loginDto = new LoginDto();


            return View(loginDto);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Giris(LoginDto dto)
        {
            var user = manager.GetAll(x => x.UserName == dto.UserName && x.Password == dto.Password).FirstOrDefault();
            if (user != null)
            {

                //Cookie icerisinde saklanacak bilgileri tutan Claim tipinden Liste olusturyoruz.
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(ClaimTypes.Role,user.Role)
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                        , new ClaimsPrincipal(claimIdentity));
                if (user.Role == "Admin")
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                else
                    return RedirectToAction("Index", "Home");


            }
            else
            {
                return View();
            }
        }
        public IActionResult YetkiHatasi()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            var registeruser = new RegisterDto();
            return View(registeruser);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterDto input)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<Kullanici>(input);
                user.Role = "User";

                
                manager.Add(user);
                return RedirectToAction("Index", "Home");

            }

            return View();
        }

    }
}
