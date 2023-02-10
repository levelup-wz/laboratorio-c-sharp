using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Comex.Web.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult HoraAtual() 
        {
            return Ok(DateAndTime.Now);

        }

    }
}
