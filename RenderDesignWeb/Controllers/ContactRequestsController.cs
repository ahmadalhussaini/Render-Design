using Microsoft.AspNetCore.Http;
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
            var contactmobail = _contactRequestsRepository.GetContactRequests();
            var List = new ContactRequestsListViewModel();
            var _designer = new List<ContactRequestsViewModel>();
            foreach (var elem in contactmobail)
            {
                var model = new ContactRequestsViewModel
                {
                    Id = elem.Id,
                    Name=elem.Name,
                    Email=elem.Email,
                    Subject=elem.Subject

                };

                _designer.Add(model);

            }
            List.ContactRequestsViewModel = _designer;
            return View(List);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var contactRequest = _contactRequestsRepository.GetContactRequests(id);
            _contactRequestsRepository.Delete(contactRequest);
            return RedirectToAction("Index");
        }

        // POST: ImageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var contactRequest = _contactRequestsRepository.GetContactRequests(id);
            _contactRequestsRepository.Delete(contactRequest);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactRequestsViewModel contactrequests)
        {

            var _contactrequests = new ContactRequests()
            {
                Name = contactrequests.Name,
                Email = contactrequests.Email,
                Phone = contactrequests.Phone,
                Subject = contactrequests.Subject

            };
            var contactrequestsid = _contactRequestsRepository.Add(_contactrequests);

            return Redirect("/Home/ContactUs");

        }


    }
}
