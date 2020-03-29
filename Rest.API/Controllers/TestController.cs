using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.API.Controllers
{
    public class TestController : Controller
    {

        [HttpGet("api/user")]
        public IActionResult Get() {

            return Ok(new { name = "zee" });

        }
    }
}
