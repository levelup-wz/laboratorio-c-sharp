using AutoMapper;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Produtos;
using Comex.Web.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[Controller]
[Route("[controller]")]
public class ProdutoController : Controller
{
    private static List<Produto> _produtos = new();
    private IMapper _mapper;

    public ProdutoController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostProduto([FromBody] CriarProdutoDto produtoDTO)
    {
        var produto = _mapper.Map<Produto>(produtoDTO);
        _produtos.Add(produto);

        return Ok();
    }

    [HttpGet]
    public IEnumerable<LerProdutoDto> GetProduto()
    {
        return _mapper.Map<List<LerProdutoDto>>(_produtos);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduto(int id)
    {
        var produto = _produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null)
            return NotFound();

        var produtoDTO = _mapper.Map<LerProdutoDto>(produto);
        return Ok(produto);
    }


}
