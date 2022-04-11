using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class DesignerController : Controller
    {
        private IDesignerRepository _designerRepository;
        public DesignerController(IDesignerRepository designerRepository)
        {
            _designerRepository = designerRepository;
        }
        public IActionResult Index()
        {
            var designer = _designerRepository.GetDesigner();
            var List = new DesignerListViewModel();
            var _designer = new List<DesignerViewModel>();
            foreach (var elem in designer)
            {
                var model = new DesignerViewModel
                {
                    Id = elem.Id,
                    Name = elem.Name,
                    Email = elem.Email,
                    Password=elem.Password,
                    PhoneNumber=elem.PhoneNumber,
                    CreatedAt=elem.CreatedAt,
                
                };

                _designer.Add(model);

            }
            List.designer = _designer;
            return View(List);
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DesignerViewModel designer)
        {

            var _designer = new Designer()
            {
                Name = designer.Name,
                Password=designer.Password,
                PhoneNumber=designer.PhoneNumber,
                CreatedAt=designer.CreatedAt,
                Email = designer.Email,
            };
           
            _designerRepository.Register(_designer);

            return RedirectToAction(nameof(Index));

        }
        public ActionResult Delete(int id)
        {
            var designer = _designerRepository.GetDesigner(id);
            _designerRepository.Delete(designer);
            return RedirectToAction("Index");
        }

        // POST: ImageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var designer = _designerRepository.GetDesigner(id);
            _designerRepository.Delete(designer);
            return RedirectToAction("Index");
        }

    }
}
