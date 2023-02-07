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
    private readonly AppDbContext _sqlite;
    private readonly IMapper _mapper;

    public ProdutoController(IMapper mapper, ComexDbContext db, AppDbContext sqlite)
    {
        _mapper = mapper;
        _sqlite = sqlite;
    }

    [HttpGet]
    public IActionResult ListarProdutos(string? categoria)
    {
        var produtos = string.IsNullOrEmpty(categoria)
            ? _sqlite.Produtos.ToList()
            : _sqlite.Produtos.Where(p => p.Categoria == categoria).ToList();

        return Ok(produtos);
    }

    [HttpPost]
    public IActionResult CriaProduto([FromBody] CriarProdutoDto produtoDto)
    {
        var produto = _mapper.Map<Produto>(produtoDto);
        _sqlite.Add(produto);
        _sqlite.SaveChanges();
        return CreatedAtAction(nameof(OberProdutoPorId), new {id = produto.Id}, produto);
    }

    [HttpGet("{id}")]
    public IActionResult OberProdutoPorId(int id)
    {
        var produto = _sqlite.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return BadRequest(new { error = "Produto inexistente" });
        return Ok(produto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
    {
        var produto = _sqlite.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return NotFound(new { error = "Produto inexistente" });

        produto = _mapper.Map(produtoDto, produto);
        _sqlite.Update(produto);
        _sqlite.SaveChanges();
        return Ok(produto);
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveProduto(int id)
    {
        var produto = _sqlite.Produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return NotFound(new { error = "Produto inexistente" });
        _sqlite.Remove(produto);
        _sqlite.SaveChanges();
        return NoContent();
    }
}
