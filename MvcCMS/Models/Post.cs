﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCMS.Models
{
    public class Post
    {
        //ID of post will be represented by unique URL, thus string
        [Display(Name = "Slug")]
        public string Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Post Content")]
        public string Content { get; set; }
        [Display(Name = "Date Created")]
        public DateTime Created { get; set; }
        //Nullable - so that if it's null it hasn't been published yet
        [Display(Name = "Date Published")]
        public DateTime? Published { get; set; }

        public IList<string> Tags { get; set; }
        public int AuthorId { get; set; }
    }
}