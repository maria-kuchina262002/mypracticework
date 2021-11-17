using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Photo")]
    public class PhotoController : ControllerBase
    {
        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpPost("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }

}
