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
            var contactmobail = _contactMobileRepository.GetContactMobails();
            var List = new ContactMobileListViewModel();
            var _designer = new List<ContactMobileViewModel>();
            foreach (var elem in contactmobail)
            {
                var model = new ContactMobileViewModel
                {
                    Id = elem.Id,
                    PhoneNumber=elem.PhoneNumber

                };

                _designer.Add(model);

            }
            List.ContactMobileViewModel = _designer;
            return View(List);
        }
        public void DeleteMobileNumberToContact(ContactMobile contactMobile)
        {
            _contactMobileRepository.Delete(contactMobile);

        }
       
    }
}
