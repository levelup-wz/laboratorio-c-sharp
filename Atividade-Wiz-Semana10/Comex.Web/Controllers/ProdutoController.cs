using AutoMapper;
using Comex.Models;
using Comex.Web.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Comex.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> _produtoList = new();
        private IMapper _mapper;

        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetHoraAtual()
        {
            var HoraAtual = DateTime.Now;
            return Ok(HoraAtual);
        }

        [HttpPost]
        public IActionResult PostProduto([FromBody] CriarProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _produtoList.Add(produto);
            return Ok();
        }

    }
}
