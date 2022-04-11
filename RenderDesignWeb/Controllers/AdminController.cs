//using Acr.UserDialogs;
//using Fluent.Infrastructure.FluentModel;
//using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Admain;
using RenderDesignWeb.ViweModel.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository _adminRepository;
        private IContactRequestsRepository _contactRequestsRepository;


        public AdminController(IContactRequestsRepository contactRequestsRepository,IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
            _contactRequestsRepository = contactRequestsRepository;
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
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult GetContactRequests()
        {
            var model = new ContactListVm();
            var List = new List<ContactVm>();
             var contacts = _contactRequestsRepository.GetContactRequests();
            foreach (var i in contacts) {
                List.Add(new ContactVm() { 
                Subject = i.Subject,
                Email = i.Email,
                Name = i.Email
                });
            }
            model.Contacts = List;
             return View(model);
        } 
        //[HttpGet]
        //public IActionResult GetContactRequest(int id)
        //{
            
        //     //_contactRequestsRepository.Delete(id);
        //     //           return View();
        //}





        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProjectController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(DesignerViewModel designer)
        //{

        //    var _designer = new Designer()
        //    {
        //        Name = designer.Name,
        //        Password = designer.Password,
        //        PhoneNumber = designer.PhoneNumber,
        //        CreatedAt = designer.CreatedAt,
        //        Email = designer.Email,
        //    };

        //    _designerRepository.Register(_designer);

        //    return RedirectToAction(nameof(Index));

        //}
    }
}
