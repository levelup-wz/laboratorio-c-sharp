using AutoMapper;
using Comex.Models;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private static List<Produto> _produtos = new();
    private readonly IMapper _mapper;

    public ProdutoController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult HoraAtual()
    {
        return Ok(DateTime.Now);
    }

    [HttpPost]
    public IActionResult CriaProduto([FromBody] CriarProdutoDto produtoDto)
    {
        var produto = _mapper.Map<Produto>(produtoDto);
        _produtos.Add(produto);
        return CreatedAtAction(nameof(OberProdutoPorId), new {id = produto.Id}, produto);
    }

    [HttpGet("{id}")]
    public IActionResult OberProdutoPorId(int id)
    {
        var produto = _produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return BadRequest(new { error = "Produto inexistente" });
        return Ok(produto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
    {
        var produto = _produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
            return BadRequest(new { error = "Produto inexistente" });

        produto = _mapper.Map(produtoDto, produto);
        return NoContent();
    }
}
