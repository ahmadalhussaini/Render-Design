using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class ContactRequestsController : Controller
    {
        private IContactRequestsRepository _contactRequestsRepository;
        public ContactRequestsController(IContactRequestsRepository contactRequestsRepository) {
            _contactRequestsRepository = contactRequestsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new ContactListVm();
            var List = new List<ContactVm>();
            var contacts = _contactRequestsRepository.GetContactRequests();
            foreach (var item in contacts)
            {
                List.Add(new ContactVm()
                {
                    Subject = item.Subject,
                    Email = item.Email,
                    Name = item.Name
                });
            }
            model.Contacts = List;
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteContactRequest(ContactRequests contact)
        {

            _contactRequestsRepository.Delete(contact);
            return View();
        }


    }
}
