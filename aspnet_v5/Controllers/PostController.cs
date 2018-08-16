using aspnet_v5.Model;
using aspnet_v5.Persistance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_v5.Controllers
{
    public class PostController : Controller
    {
        private readonly DataContext Context;


        public PostController(DataContext context)
        {
            Context = context;
        }

        [HttpGet("/api/posts")]
        public IEnumerable<Post> GetPosts()
        {
            return Context.Post;
        }
    }
}
