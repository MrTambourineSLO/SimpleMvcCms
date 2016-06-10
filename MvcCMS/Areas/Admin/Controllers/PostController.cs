using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCMS.Data;
using MvcCMS.Models;

namespace MvcCMS.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        private readonly IPostRepository _repository ;
        public PostController (IPostRepository repository)
        {
            _repository = repository;
        }
        // /admin/post
        public ActionResult Index()
        {
            return View();
        }


        // /admin/post/create 
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            var model = new Post();

            return View(model);
        }
        // /admin/post/create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public ActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //TODO: update model in data store
            return RedirectToAction("Index");
        }
        // /admin/post/edit/post-to-edit
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            //TODO: to retrive the model from the data store
            var model = new Post();

            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        [Route("edit/{id}")]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //TODO: update model in data store
            return RedirectToAction("Index");

        }
    }
} 