using AutoMapper;
using Comex.Web.Data.Dto;
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
        private static int id = 1;

        public ProdutoController(IMapper mapper)
        {
            _imapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarProduto ([FromBody] CriarProdutoDTO produtoDto) 
        {
            Produto produto = _imapper.Map<Produto>(produtoDto);
            produto.Id = id++;
            _produto.Add(produto);

            return CreatedAtAction(nameof(ObterProdutoPorId), new { Id = produto.Id }, produto);
        }

        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(int id) 
        {
            var produto = _produto.FirstOrDefault(produto => produto.Id == id);
            
            if(produto != null)
            {
                LerProdutoDto produtoDto = _imapper.Map<LerProdutoDto>(produto);
                return Ok(produtoDto);
            }

            return NotFound();
        }


        [HttpGet]
        public ActionResult HoraAtual() 
        {
            return Ok(DateAndTime.Now);

        }

       

    }
}
