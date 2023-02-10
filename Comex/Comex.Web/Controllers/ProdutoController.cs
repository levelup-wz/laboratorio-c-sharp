using Comex.Web.Models;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Comex.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private static int id = 0;
    private IMapper _mapper;
    private static List<Produto> _produtos = new List<Produto>();

    public ProdutoController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarProduto([FromBody] CriarProdutoDto produtoDto)
    {
        Produto produto = _mapper.Map<Produto>(produtoDto);
        produto.Id = ++id;

        _produtos.Add(produto);

        return CreatedAtAction(nameof(ObterProdutoPorId), new { Id = produto.Id }, produto);
    }

    [HttpGet("{id}")]
    public IActionResult ObterProdutoPorId(int id)
    {
        var produto = _produtos.FirstOrDefault(produto => produto.Id == id);

        if (produto != null)
        {
            LerProdutoDto produtoDto = _mapper.Map<LerProdutoDto>(produto);
            return Ok(produtoDto);
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
    {
        var produto = _produtos.FirstOrDefault(produto => produto.Id == id);
        
        if (produto == null) return NotFound();

        _mapper.Map(produtoDto, produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverProduto(int id)
    {
        var produto = _produtos.FirstOrDefault(produto => produto.Id == id);

        if (produto == null) return NotFound();

        _produtos.Remove(produto);
        return NoContent();
    }

    [HttpGet]
    public IActionResult InformarHorario()
    {
        return Ok(DateTime.Now);
    }
}
