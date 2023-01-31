using AutoMapper;
using Comex.Modelos.Produtos;
using Comex.Web.Data.DTOs;
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

    [HttpGet]
    public IEnumerable<LerProdutoDTO> GetProduto()
    {
        return _mapper.Map<List<LerProdutoDTO>>(_produtos);
    }

    [HttpPost]
    public IActionResult PostProduto([FromBody]CriarProdutoDTO produtoDTO)
    {
        var produto = _mapper.Map<Produto>(produtoDTO);
        _produtos.Add(produto);

        return Ok();
    }
}
