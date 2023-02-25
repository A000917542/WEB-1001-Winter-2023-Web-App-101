using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_1001_Winter_2023_Web_App_101.Models;

namespace WEB_1001_Winter_2023_Web_App_101.Controllers
{
    public class BlogPostController : Controller
    {
        private static ICollection<BlogPost> posts = new List<BlogPost>() { new BlogPost() { Id = 1, Content = "Content", Description = "Description", Title = "Title" } };

        // GET: BlogPostController
        public ActionResult Index()
        {
            return View(posts);
        }

        // GET: BlogPostController/Details/5
        public ActionResult Details(int id)
        {
            var ret = posts.First(post => post.Id == id);

            return View(ret);
        }

        // GET: BlogPostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogPost post)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    posts.Add(post);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }

        // GET: BlogPostController/Edit/5
        public ActionResult Edit(int id)
        {
            var ret = posts.First(post => post.Id == id);

            return View(ret);
        }

        // POST: BlogPostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlogPost editedPost)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var ret = posts.First(post => post.Id == id);
                    posts.Remove(ret);
                    posts.Add(editedPost);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            return View(editedPost);
        }

        // GET: BlogPostController/Delete/5
        public ActionResult Delete(int id)
        {
            var ret = posts.First(post => post.Id == id);
            return View(ret);
        }

        // POST: BlogPostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BlogPost deletedPost)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var ret = posts.First(post => post.Id == id);
                    posts.Remove(ret);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            return View(deletedPost);
        }
    }
}
