using AutoMapper;
using Comex.Entidades;
using Comex.Web.Data;
using Comex.Web.Data.Dto;
using Microsoft.EntityFrameworkCore;

namespace Comex.Web.Repositorio.ProdutoRepositorio
{
    public class ProdutoRepositorio
    {
        private readonly ComexDbSqliteContext _context;
        //private readonly ComexDbContext _context;
        private readonly IMapper _mapper;

        public ProdutoRepositorio(IMapper mapper, ComexDbSqliteContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public ProdutoDto CriarProduto(CriarProdutoDtoCategoria criarProdutoDto)
        {
            var produto = _mapper.Map<Produto>(criarProdutoDto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> ListarProdutos(string? categoria)
        {
            var listProdutos = new List<Produto>();

            if (string.IsNullOrEmpty(categoria))
                listProdutos = _context.Produtos.Include(p => p.Categoria).ToList();
            else
                listProdutos = _context.Produtos.Include(p => p.Categoria).Where(p => p.Categoria.Nome == categoria.ToUpper()).ToList();

            var listaProdutosDto = listProdutos.Select(p => _mapper.Map<ProdutoDto>(p));


            return listaProdutosDto;
        }

        public ProdutoDto ObterProdutoPorId(int id)
        {
            var produto = _context.Produtos.Include(p => p.Categoria).FirstOrDefault(p => p.Id == id);

            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            if (produto == null)
                return null;
            

            return produtoDto;
        }

        public void AtualizarProduto(int id, CriarProdutoDtoCategoria atualizarProdutoDto)
        {
            var produto = _context.Produtos.Find(id);
            
            var produtoUpdate = _mapper.Map(atualizarProdutoDto, produto);
            
            _context.Produtos.Update(produtoUpdate);
            _context.SaveChanges();
        }

        public void RemoverProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}
