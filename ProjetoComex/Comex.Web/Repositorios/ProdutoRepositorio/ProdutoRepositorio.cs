using AutoMapper;
using Comex.Entidades;
using Comex.Web.Data.Dto;

namespace Comex.Web.Repositorio.ProdutoRepositorio
{
    public class ProdutoRepositorio
    {
        private static List<Produto> Produtos = new List<Produto>();
        private readonly IMapper _mapper;

        public ProdutoRepositorio(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProdutoDto CriarProduto(CriarProdutoDtoCategoria criarProdutoDto)
        {
            var produto = _mapper.Map<Produto>(criarProdutoDto);
            Produtos.Add(produto);

            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> ListarProdutos()
        {
            var produtosDto = Produtos.ToList();

            var listaProdutosDto = produtosDto.Select(p => _mapper.Map<ProdutoDto>(p));

            return listaProdutosDto;
        }

        public ProdutoDto ObterProdutoPorId(int id)
        {
            var produto = Produtos.FirstOrDefault(p => p.Id == id);

            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            if (produto == null)
            {
                return null;
            }

            return produtoDto;
        }
    }
}
