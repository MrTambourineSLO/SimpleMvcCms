using System;
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
    }
}
