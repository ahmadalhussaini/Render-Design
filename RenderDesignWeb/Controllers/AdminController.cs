using Acr.UserDialogs;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository Adminrepo;

        public AdminController(IAdminRepository adminrepo)
        {
            Adminrepo = adminrepo;
        }
        // GET: AdminController
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
       
        }

    }
}
