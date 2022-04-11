using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class ContactRequestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
