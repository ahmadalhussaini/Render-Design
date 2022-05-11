//using Acr.UserDialogs;
//using Fluent.Infrastructure.FluentModel;
//using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Admain;
using RenderDesignWeb.ViweModel.Contact;
using RenderDesignWeb.ViweModel.Image;
using RenderDesignWeb.ViweModel.Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class AdminController : Controller
    {

        public IProjectRepository _projectRepository;
        private IImageRepository _imageRepository;

        public AdminController(IProjectRepository projectRepository, IImageRepository imageRepository) {
            _projectRepository = projectRepository;
            _imageRepository = imageRepository;
        }
        public ActionResult IndexProject()
        {
            var projects = _projectRepository.GetProjects();
            var List = new ProjectListViewModel();
            var _projects = new List<ProjectViewModel>();
            foreach (var elem in projects)
            {
                var model = new ProjectViewModel
                {
                    Id = elem.Id,
                    Name = elem.Name,
                    Description = elem.Description,
                    Location = elem.Location,
                    Type = elem.Type,


                };

                _projects.Add(model);

            }
            List.ProjectsViewModel = _projects;
            return View(List);
        }
        public ActionResult IndexImage()
        {
            var images = _imageRepository.GetImages();
            var List = new ImageListViewModel();
            var _images = new List<ImageViewModel>();
            foreach (var elem in images)
            {
                var model = new ImageViewModel
                {
                    Id = elem.Id,
                    ProjectId = elem.ProjectId,
                    PathImg = elem.PathImg,

                };
                _images.Add(model);

            }
            List.images = _images;
            return View(List);
        }
        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            var project = _projectRepository.GetProject(id);
            var imges = _imageRepository.GetImages(id);
            var List = new ImageListViewModel();
            var _images = new List<ImageViewModel>();
            foreach (var elem in imges)
            {
                var mode = new ImageViewModel
                {
                    PathImg = elem.PathImg
                };
                _images.Add(mode);
            }
            var model = new ProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                Location = project.Location,
                Type = project.Type,
                images = _images

            };

            return View(model);
        }

   

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            var project = _projectRepository.GetProject(id);
            var imges = _imageRepository.GetImages(id);

            foreach (var elem in imges)
            {
                _imageRepository.Delete(elem);

            };

            _projectRepository.Delete(project);

            return RedirectToAction("IndexProject");
        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var pro = _projectRepository.GetProject(id);
            _projectRepository.Delete(pro);
            return RedirectToAction("IndexProject");
        }
        public string Upload(IFormFile image, string path)
        {
            if (image == null || image.Length == 0)
                return null;

            var folderName = Path.Combine("upload", path);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            string extension = Path.GetExtension(image.FileName);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string nameToUse = path + DateTime.Now.Ticks.ToString();
            nameToUse = nameToUse.Replace(" ", String.Empty);

            var uniqueFileName = $"{nameToUse}{path}{image.Name}{extension}";
            var dbPath = Path.Combine(folderName, uniqueFileName);

            using (var fileStream = new FileStream(Path.Combine(filePath, uniqueFileName), FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            var Url = $"{dbPath}";

            var result = Url;
            return result.Replace("\\", "/");
        }
    }
}
