using Microsoft.AspNetCore.Mvc;
using RenderDesignWeb.Models;
using RenderDesignWeb.Models.Interface;
using RenderDesignWeb.ViweModel.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.Controllers
{
    public class PostController : Controller
    {
        public IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public void DeletePost(Post post)
        {
            _postRepository.Delete(post);

        }
        public IActionResult GetContactMobiles()
        {
            var model = new List<PostViewModel>();
            var contacts = _postRepository.GetPosts();
            foreach (var item in contacts)
            {
                model.Add(new PostViewModel()
                {
                    Name = item.Name,
                    Subject=item.Subject,
                    Id = item.Id,
                });
            }
            return View(model);

        }
    }
}
