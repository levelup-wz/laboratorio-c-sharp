using AutoMapper;
using Comex.Models;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> _produtoList = new();
        private IMapper _mapper;

        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetHoraAtual()
        {
            var HoraAtual = DateTime.Now;
            return Ok(HoraAtual);
        }

        [HttpPost]
        public IActionResult PostProduto([FromBody] CriarProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _produtoList.Add(produto);
            if (produto == null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(int id)
        {
            var produto = _produtoList.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound("O produto não existe");
            }
            return Ok(produto);
        }
    }
}
