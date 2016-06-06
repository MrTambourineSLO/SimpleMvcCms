﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCMS.Models;

namespace MvcCMS.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        // /admin/post
        public ActionResult Index()
        {
            return View();
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
        [Route("edit/{id}")]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid())
            {
                return View(model);
            }
            //TODO: update model in data store
            return RedirectToAction("Index");

        }
    }
}