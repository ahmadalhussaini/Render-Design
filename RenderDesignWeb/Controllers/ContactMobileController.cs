using Microsoft.AspNetCore.Http;
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
        public ActionResult Delete(int id)
        {
            var contactMobail = _contactMobileRepository.GetContactMobail(id);
            _contactMobileRepository.Delete(contactMobail);
            return RedirectToAction("Index");
        }

        // POST: ImageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var contactRequest = _contactMobileRepository.GetContactMobail(id);
            _contactMobileRepository.Delete(contactRequest);
            return RedirectToAction("Index");
        }

    }
}
