using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.Models;

namespace DotNetCore.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        // POST: RW/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Post collection)
        {
            try
            {
                // TODO: Add insert logic here
                //TempData["post"] = collection;

                if (ModelState.IsValid)
                {

                    return RedirectToAction(nameof(Index));
                }
                return View();


            }
            catch
            {
                return View();
            }
        }

        public List<Post> LoadPosts()
        {
            List<Post> posts = new List<Post>();
            //posts.Add(TempData["post"] as Post);
            posts.Add(new Post() { id = 1, Title = "Title 1", body = "Body 1" });
            posts.Add(new Post() { id = 2, Title = "Title 2", body = "Body 2" });
            posts.Add(new Post() { id = 3, Title = "Title 3", body = "Body 3" });
            posts.Add(new Post() { id = 4, Title = "Title 4", body = "Body 4" });
            return posts;
        }

        public IActionResult Index()
        {
            List<Post> posts = LoadPosts();

            return View(posts);
        }
        public IActionResult GetAllPosts()
        {
            List<Post> posts = LoadPosts();

            ViewData["posts"] = posts;
            return View();
        }
        public IActionResult GetPost()
        {
            Post post = new Post();
            post.id = 1;
            post.Title = "sdfsdafasfd";
            post.body = "wdsfdsfsdfsdfsdfsd";
            return View(post);
        }
       

    }
}
