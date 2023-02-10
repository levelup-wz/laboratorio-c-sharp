using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;




namespace Comex.Web.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> _produto = new();
        private IMapper _imapper;


        [HttpGet]
        public ActionResult HoraAtual() 
        {
            return Ok(DateAndTime.Now);

        }

       

    }
}
