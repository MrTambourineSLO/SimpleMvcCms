using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCMS.Models
{
    public class Post
    {
        //ID of post will be represented by unique URL, thus string
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        //Nullable - so that if it's null it hasn't been published yet
        public DateTime? Published { get; set; }
        public int AuthorId { get; set; }
    }
}