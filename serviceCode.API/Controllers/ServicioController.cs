using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace serviceCode.API.Controllers
{
    [Route("api/servicio")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Index(int id)
        {
            return Ok($"this is a test {id} ...");
        }

    }
}
