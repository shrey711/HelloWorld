using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : ControllerBase
    {
        [HttpGet] 
        public IActionResult Hello_World() 
        {
            return Ok(new { Message = "HelloWorld" });
        }
    }
}
