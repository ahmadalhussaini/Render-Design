using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class ContactMobileController : Controller
    {
        public IContactMobileRepository _contactMobileRepository;
        public ContactMobileController(IContactMobileRepository contactMobileRepository) {
            _contactMobileRepository = contactMobileRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public void EnterMobileNumberToContact(ContactMobile contactMobile)
        {
            _contactMobileRepository.Add(contactMobile);
        }
    }
}
