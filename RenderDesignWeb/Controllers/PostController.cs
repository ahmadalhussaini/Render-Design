using Microsoft.AspNetCore.Http;
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
                    Subject=elem.Subject,
                    Date=elem.Date

                };

                _designer.Add(model);

            }
            List.PostViewModel = _designer;
            return View(List);
        }
        public ActionResult Delete(int id)
        {
            var post = _postRepository.GetPost(id);
            _postRepository.Delete(post);
            return RedirectToAction("Index");
        }

        // POST: ImageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var post = _postRepository.GetPost(id);
            _postRepository.Delete(post);
            return RedirectToAction("Index");
        }

    }
}
