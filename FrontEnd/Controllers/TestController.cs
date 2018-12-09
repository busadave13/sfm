using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("node")]
        public ActionResult<string> Get()
        {
            return Environment.MachineName;
        }
    }
}
