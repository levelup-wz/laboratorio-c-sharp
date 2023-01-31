using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        [Route("/time")]
        public IActionResult GetTime()
        {
            return Ok(DateTime.Now);
        }
    };
    
}