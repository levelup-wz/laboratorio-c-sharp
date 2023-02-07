using AutoMapper;
using Comex.Models;
using Comex.Web.Data;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ComexDbContext _context;
        private IMapper _mapper;

        public ProdutoController(ComexDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/DateTime")]
        public IActionResult GetHoraAtual()
        {
            var HoraAtual = DateTime.Now;
            return Ok(HoraAtual);
        }

        [HttpPost]
        public IActionResult PostProduto([FromBody] CriarProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _context.Add(produto);
            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpGet("/List")]
        public IActionResult ListaDeProdutos()
        {
            var produtoList = _context;
            if (produtoList.Produtos.Any())
            {
                return Ok(produtoList);
            }
            return NotFound("Não existe produto na lista.");
        }

        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound("O produto não existe.");
            }
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound("O produto não existe.");
            }
            _mapper.Map(produtoDto, produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveProduto(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound("O produto não existe.");
            }
            _context.Remove(produto);
            return NoContent();
        }
    }
}
