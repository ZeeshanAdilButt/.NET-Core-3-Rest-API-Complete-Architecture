using Microsoft.AspNetCore.Mvc;
using Rest.API.Contracts.V1;
using Rest.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.API.Controllers.V1
{
    public class PostsController : Controller
    {

        List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult Get()
        {

            return Ok(_posts);

        }


    }
}
