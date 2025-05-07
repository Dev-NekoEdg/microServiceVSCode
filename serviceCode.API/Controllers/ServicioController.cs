using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serviceCode.Application.Services.Book;

namespace serviceCode.API.Controllers
{
    [Route("api/servicio")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        private readonly IBookService service;

        public ServicioController(IBookService service)
        {
            this.service = service;
        }


        [HttpPost]
        public IActionResult Index(int id)
        {
            return Ok($"this is a test {id} ...");
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await this.service.GetBooks();
            return Ok(result);
        }
    }
}
