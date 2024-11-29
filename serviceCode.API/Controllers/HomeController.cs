using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace serviceCode.API.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            int id = await Task.Run(() => DateTime.Now.DayOfYear);
            return Ok($"this is a test {id} ...");
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("this is a test...");
        }
    }
}
