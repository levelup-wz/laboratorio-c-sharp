using AutoMapper;
using Comex.Modelos.Produtos;
using Comex.Web.Data;
using Comex.Web.Data.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers;

[Controller]
[Route("[controller]")]
public class ProdutoController : Controller
{
    private ComexDbContext _context;
    private IMapper _mapper;

    public ProdutoController(IMapper mapper, ComexDbContext context)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostProduto([FromBody] CriarProdutoDto produtoDto)
    {
        var produto = _mapper.Map<Produto>(produtoDto);
        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return Ok();
    }

    [HttpGet]
    public IEnumerable<LerProdutoDto> GetProduto()
    {
        return _mapper.Map<List<LerProdutoDto>>(_context.Produtos);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduto(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null)
            return NotFound();

        var produtoDto = _mapper.Map<LerProdutoDto>(produto);
        return Ok(produto);
    }

    [HttpPut("{id}")]
    public IActionResult PutProduto(int id, [FromBody] AtualizarProdutoDto produtoDto)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null)
            return NotFound();

        _mapper.Map(produtoDto, produto);
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult PatchProduto(int id, JsonPatchDocument<AtualizarProdutoDto> patch)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null)
            return NotFound();

        var patchProduto = _mapper.Map<AtualizarProdutoDto>(produto);

        patch.ApplyTo(patchProduto, ModelState);
        if (!TryValidateModel(patchProduto))
            return ValidationProblem(ModelState);

        _mapper.Map(patchProduto, produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduto(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null)
            return NotFound();

        _context.Remove(produto);
        _context.SaveChanges();

        return NoContent();
    }
}
