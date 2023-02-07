using AutoMapper;
using Comex.Models;
using Comex.Web.Data;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly ComexDbContext _db;
    private readonly IMapper _mapper;

    public ProdutoController(IMapper mapper, ComexDbContext db)
    {
        _mapper = mapper;
        _db = db;
    }

    [HttpGet]
    public IActionResult HoraAtual()
    {
        return Ok(DateTime.Now);
    }

    [HttpGet]
    [Route("listarTodos")]
    public IActionResult ListarProdutos()
    {
        var produtos = _db.Produtos.ToList();
        return Ok(produtos);
    }

    [HttpPost]
    public IActionResult CriaProduto([FromBody] CriarProdutoDto produtoDto)
    {
        var produto = _mapper.Map<Produto>(produtoDto);
        _db.Add(produto);
        return CreatedAtAction(nameof(OberProdutoPorId), new {id = produto.Id}, produto);
    }

    [HttpGet("{id}")]
    public IActionResult OberProdutoPorId(int id)
    {
        var produto = _db.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return BadRequest(new { error = "Produto inexistente" });
        return Ok(produto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
    {
        var produto = _db.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return NotFound(new { error = "Produto inexistente" });

        produto = _mapper.Map(produtoDto, produto);
        return Ok(produto);
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveProduto(int id)
    {
        var produto = _db.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return NotFound(new { error = "Produto inexistente" });
        _db.Remove(produto);
        return NoContent();
    }
}
