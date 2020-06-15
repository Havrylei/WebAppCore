using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("It a version 1.0.2");
        }
    }
}
