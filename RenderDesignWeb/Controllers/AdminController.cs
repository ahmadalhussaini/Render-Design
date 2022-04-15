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
using RenderDesignWeb.ViweModel.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class AdminController : Controller
    {

        public IProjectRepository _projectRepository;

        public AdminController(IProjectRepository projectRepository) {
            _projectRepository = projectRepository;
        }
        public IActionResult Projects() {
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
    }
}
