using Comex.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Comex.Web.Data.Dto
{
    public class CriarProdutoDtoCategoria
    {
        public string Nome { get; set; }

        public double PrecoUnitario { get; set; }

        public int QuantidadeEstoque { get; set; }

        public Categoria Categoria { get; set; }

        public CriarProdutoDtoCategoria(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Categoria = categoria;
        }
    }
}
