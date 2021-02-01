using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedController : Controller
    {
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(new { Value = "This is a return message" });
        }
    }
}
