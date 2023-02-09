using Comex.Web.Models;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Comex.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{

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

        _produtos.Add(produto);

        return Ok(_produtos);
    }

    [HttpGet]
    public IActionResult InformarHorario()
    {
        return Ok(DateTime.Now);
    }
}
