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
            return Ok(HoraAtual.ToString("dd/MM/yyyy HH:mm"));
        }

        [HttpPost]
        public IActionResult PostProduto([FromBody] CriarProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _context.Add(produto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpGet("/List")]
        public IActionResult ListaDeProdutos([FromQuery] string categoria)
        {
            var produtos = _context.Produtos.ToList();
            if (!string.IsNullOrEmpty(categoria))
            {
                produtos = produtos.Where(p => p.Categoria == categoria).ToList();
            }
            if (!produtos.Any())
            {
                return NotFound();
            }

            return Ok(produtos);
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
            _context.SaveChanges();
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
            _context.SaveChanges();
            return NoContent();
        }
    }
}
