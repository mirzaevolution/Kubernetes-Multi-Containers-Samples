using System;
using Microsoft.AspNetCore.Mvc;
using K8s.Api.Models;
namespace K8s.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoApiController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get() => Ok(new EchoResponse
        {
            MachineName = Environment.MachineName,
            Message = "Hello World!"
        });
    }
}