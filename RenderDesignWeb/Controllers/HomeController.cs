using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Designer;
using RenderDesignWeb.ViweModel.Image;
using RenderDesignWeb.ViweModel.Project;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IProjectRepository _projectRepository;
        private IImageRepository _imageRepository;
        private IDesignerRepository _designerRepository;


        public HomeController(IProjectRepository projectRepository, IImageRepository imageRepository, IDesignerRepository designerRepository)
        {
            _projectRepository = projectRepository;
            _imageRepository = imageRepository;
            _designerRepository = designerRepository;

        }
        public IActionResult Home()
        {
            return View();
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
                Password = designer.Password,
                PhoneNumber = designer.PhoneNumber,
                CreatedAt = designer.CreatedAt,
                Email = designer.Email,
            };

            _designerRepository.Register(_designer);

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Projects(string type)
        {
            var projects = _projectRepository.GetProjects(type).OrderByDescending(x => x.Id).ToList();
            var model = new List<ProjectViewModel>();
            var pro = new ProjectListViewModel();
            foreach (var elem in projects)
            {
                var imge = _imageRepository.GetImages(elem.Id).Take(1).ToList();

                model.Add(new ProjectViewModel()
                {
                    Id = elem.Id,
                    Name = elem.Name,
                    FirstImage = imge[0].PathImg,
                    Type = elem.Type

                });

            }
            pro.Projects = model;

            return View(pro);
        }
        public IActionResult Project(int id)
        {

            var project = _projectRepository.GetProject(id);
            var images = _imageRepository.GetImages(project.Id);
            var imagesvm = new List<ImageViewModel>();
            foreach (var elem in images)
            {

                imagesvm.Add(new ImageViewModel()
                {
                    PathImg = elem.PathImg
                });
            }
            var projectView = new ProjectViewModel()
            {

                Name = project.Name,
                
                Description = project.Description,
                Location=project.Location,
                DesignerId=project.DesignerId,
                images = imagesvm

            };

           

            return View(projectView);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        
        
        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
