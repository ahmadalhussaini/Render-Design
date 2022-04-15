using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.ContactMobile;
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
        public void DeleteMobileNumberToContact(ContactMobile contactMobile)
        {
            _contactMobileRepository.Delete(contactMobile);

        }
        public IActionResult GetContactMobiles()
        {
            var model = new List<ContactMobileVM>();
            var contacts= _contactMobileRepository.GetContactMobails();
            foreach (var item in contacts) {
                model.Add(new ContactMobileVM()
                {
                    PhoneNumber = item.PhoneNumber,
                    Id=item.Id,
                }) ;
            }
            return View(model);

        }
    }
}
