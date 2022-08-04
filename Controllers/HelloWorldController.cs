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
        public string SayHello()
        {
            return $"Hello, Dear Friends. {DateTime.Now}";
        }
    }
}
