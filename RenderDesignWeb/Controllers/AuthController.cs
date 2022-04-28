using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Admain;
using RenderDesignWeb.ViweModel.Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class AuthController : Controller
    {
        private IAdminRepository _adminRepository;
        private IDesignerRepository _designerRepository;
        const string SessionId = "0";



        public AuthController(IAdminRepository adminRepository, IDesignerRepository designerRepository) {
            _adminRepository = adminRepository;
            _designerRepository = designerRepository;
        }
        [HttpGet]
        public IActionResult Login()

        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            if (ModelState.IsValid)
            {

                var admin = _adminRepository.Login(Email, Password);
                var designer = _designerRepository.Login(Email, Password);

                if (admin == null && designer == null)
                {
                    TempData["Error"] = "Username or Password is incorrect";
                }
                if (admin != null) {
                    var clamis = new List<Claim>();
                    clamis.Add(new Claim("userId", admin.Id.ToString()));
                    clamis.Add(new Claim("Email", admin.Email));
                    clamis.Add(new Claim(ClaimTypes.NameIdentifier, admin.Email));
                    var claimsIdentity = new ClaimsIdentity(clamis, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    var authProperties = new AuthenticationProperties
                    {

                        ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                        IsPersistent = true,

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return Redirect("/Admin/IndexProject");
                }
                if (designer != null) {
                   
                    HttpContext.Session.SetInt32(SessionId, designer.Id);

                    var clamis = new List<Claim>();
                    clamis.Add(new Claim("userId", designer.Id.ToString()));
                    clamis.Add(new Claim("Email", designer.Email));
                    clamis.Add(new Claim(ClaimTypes.NameIdentifier, designer.Email));
                    var claimsIdentity = new ClaimsIdentity(clamis, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    var authProperties = new AuthenticationProperties
                    {

                        ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                        IsPersistent = true,

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return Redirect("/Project/Index");
                }
                TempData["Error"] = "Username or Password is incorrect";
                return RedirectToAction("Login");
            }
              
            TempData["Error"] = "Username or Password is incorrect";
            return RedirectToAction("Login");
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterAsync(string Name , string Password,string PhoneNumber, string Email,DateTime CreatedAt)
        {

            var _designer = new Designer()
            {
                Name = Name,
                Password = Password,
               PhoneNumber = PhoneNumber,
                CreatedAt = CreatedAt,
                Email = Email,
            };

           var AddedDesigner =  _designerRepository.Register(_designer);
            HttpContext.Session.SetInt32(SessionId, AddedDesigner.Id);

            var clamis = new List<Claim>();
            clamis.Add(new Claim("userId", AddedDesigner.Id.ToString()));
            clamis.Add(new Claim("Email", AddedDesigner.Email));
            clamis.Add(new Claim(ClaimTypes.NameIdentifier, AddedDesigner.Email));
            var claimsIdentity = new ClaimsIdentity(clamis, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            var authProperties = new AuthenticationProperties
            {

                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1),
                IsPersistent = true,

            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return Redirect("/Project/Index");
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetInt32(SessionId, 0);

            return RedirectToAction("Login");
        }


    }
}
