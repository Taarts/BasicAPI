using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // the name of the method is to be clear to *me* (programmer)
        // Doesn't tell ASP a damn thing...
        [HttpGet]
        public string SayHello(string who)
        {
            // string whoOrWorld;

            // if (who == null)
            // {
            //     whoOrWorld = "World";
            // }
            // else
            // {
            //     whoOrWorld = who;
            // }
            string whoOrWorld = (who == null) ? "World" : who;

            return $"Hello, {whoOrWorld}. It is currently {DateTime.Now}";
        }
    }
}
