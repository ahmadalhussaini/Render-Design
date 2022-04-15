using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
        public async Task<IActionResult> Login(LoginViweModel model)
        {
            if (ModelState.IsValid)
            {

                var admin = _adminRepository.Login(model.Email, model.Password);
                if (admin == null)
                {
                    TempData["Error"] = "Username or Password is incorrect";
                    return View("Login");
                }
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

                return Redirect("/Project/Index");
            }
            TempData["Error"] = "Username or Password is incorrect";
            return RedirectToAction("Login");
        }
         [HttpGet]
        public IActionResult DesignerLogin()

        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DesignerLogin(LoginViweModel model)
        {
            if (ModelState.IsValid)
            {

                var designer = _designerRepository.Login(model.Email, model.Password);
                if (designer == null)
                {
                    TempData["Error"] = "Username or Password is incorrect";
                    return View("Login");
                }
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



        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterAsync(DesignerViewModel designer)
        {

            var _designer = new Designer()
            {
                Name = designer.Name,
                Password = designer.Password,
                PhoneNumber = designer.PhoneNumber,
                CreatedAt = designer.CreatedAt,
                Email = designer.Email,
            };

           var AddedDesigner =  _designerRepository.Register(_designer);

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
            return RedirectToAction("Login");
        }


    }
}
