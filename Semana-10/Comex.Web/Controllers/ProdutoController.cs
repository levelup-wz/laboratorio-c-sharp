using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult HoraAtual()
        {
            return Ok(DateTime.Now);
        }
    }
}
