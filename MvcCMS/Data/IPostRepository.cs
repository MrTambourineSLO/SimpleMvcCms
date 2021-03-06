﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCMS.Models;

namespace MvcCMS.Data
{
    public interface IPostRepository
    {
        Post Get(object id);

        void Edit(string id, Post updatedItem);

        void Create(Post model);

        IEnumerable<Post> GetAll();
    }
}
