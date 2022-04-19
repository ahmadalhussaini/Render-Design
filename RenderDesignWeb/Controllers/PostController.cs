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
            var contactmobail = _postRepository.GetPosts();
            var List = new PostListViewModel();
            var _designer = new List<PostViewModel>();
            foreach (var elem in contactmobail)
            {
                var model = new PostViewModel
                {
                    Id = elem.Id,
                    Name=elem.Name,
                    Subject=elem.Subject

                };

                _designer.Add(model);

            }
            List.PostViewModel = _designer;
            return View(List);
        }
        public void DeletePost(Post post)
        {
            _postRepository.Delete(post);

        }
        
    }
}
