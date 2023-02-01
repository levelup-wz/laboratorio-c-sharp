using Comex.Entidades;
using Comex.Web.Data.Dto;
using Comex.Web.Repositorio.ProdutoRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepositorio _repository;

        public ProdutoController(ProdutoRepositorio repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("/time")]
        public IActionResult GetTime()
        {
            return Ok(DateTime.Now);
        }

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_repository.ListarProdutos());
        }

        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(int id)
        {
            var produto = _repository.ObterProdutoPorId(id);

            if (produto == null)
            {
                return NotFound("Produto não localizado");
            }

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult CriarProduto([FromBody] CriarProdutoDto request)
        {
            if (request == null)
            {
                return BadRequest("Elemento inválido");
            }

            var categoria = new Categoria(request.Categoria);

            var produto = new CriarProdutoDtoCategoria(request.Nome, request.PrecoUnitario, request.QuantidadeEstoque, categoria);

            var response = _repository.CriarProduto(produto);

            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = response.Id }, response);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, AtualizarProdutoDto request)
        {

            var findProduto = _repository.ObterProdutoPorId(id);

            if (findProduto == null)
            {
                return NotFound("Produto não localizado");
            }

            var categoria = new Categoria(request.Categoria);
            var produto = new CriarProdutoDtoCategoria(request.Nome, request.PrecoUnitario, request.QuantidadeEstoque, categoria);

            _repository.AtualizarProduto(id, produto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveProduto(int id)
        {
            var findProduto = _repository.ObterProdutoPorId(id);
            if (findProduto == null)
            {
                return NotFound("Produto não localizado");
            }
            _repository.RemoverProduto(id);
            return NoContent();
        }
    }
}