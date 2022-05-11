using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Contact;
using RenderDesignWeb.ViweModel.Designer;
using RenderDesignWeb.ViweModel.Home;
using RenderDesignWeb.ViweModel.Image;
using RenderDesignWeb.ViweModel.Post;
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
        private IContactRequestsRepository  _contactRequestsRepository;
        public IContactMobileRepository _contactMobileRepository;
        public IPostRepository _postRepository;



        public HomeController(IContactRequestsRepository contactRequestsRepository,
            IContactMobileRepository contactMobileRepository,
            IProjectRepository projectRepository, IImageRepository imageRepository, IDesignerRepository designerRepository,
            IPostRepository postRepository)
        {
            _projectRepository = projectRepository;
            _imageRepository = imageRepository;
            _designerRepository = designerRepository;
            _contactRequestsRepository = contactRequestsRepository;
            _contactMobileRepository = contactMobileRepository;
            _postRepository = postRepository;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Projects()
        {
            var projects = _projectRepository.GetProjects().OrderByDescending(x => x.Id).ToList();
            var model = new List<HomeViewModel>();
            var vm = new HomeListViewModel();
            foreach (var elem in projects)
            {
                var imge = _imageRepository.GetImages(elem.Id).Take(1).ToList();

                model.Add(new HomeViewModel()
                {
                    Id = elem.Id,
                    Name = elem.Name,
                    FirstImage = imge[0].PathImg,
                    Type = elem.Type

                });

            }
            vm.Projects = model;

            return View(vm);
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
        public IActionResult ProjectsByType(string type)
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
            pro.ProjectsViewModel = model;

            return View(pro);
        } 
        public IActionResult ProjectsByDesigner(string name)
        {
            var projects = _projectRepository.ProjectsByDesigner(name).OrderByDescending(x => x.Id).ToList();
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
            pro.ProjectsViewModel = model;

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
       
        [HttpGet]
        public IActionResult Post()
        {
            var contactmobail = _postRepository.GetPosts().OrderByDescending(x => x.Id).ToList();
            var List = new PostListViewModel();
            var _designer = new List<PostViewModel>();
            foreach (var elem in contactmobail)
            {
                var model = new PostViewModel
                {
                    Id = elem.Id,
                    Name = elem.Name,
                    Subject = elem.Subject,
                    Date=elem.Date

                };

                _designer.Add(model);

            }
            List.PostViewModel = _designer;
        
        

            return View(List);
         
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Addpost(string Name ,string Subject)
        {
            _postRepository.Add(new Post()
            {
                Name = Name,
                Subject = Subject,
                Date = DateTime.Now
                
                
            });


            return RedirectToAction(nameof(Index));
         
        }

       
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactUs(ContactRequestsViewModel contactrequests)
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
        public void EnterMobileNumberToContact(ContactMobile contactMobile)
        {
            _contactMobileRepository.Add(contactMobile);

        }

    }
}
