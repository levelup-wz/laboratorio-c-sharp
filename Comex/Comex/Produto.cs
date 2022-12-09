using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public Categoria ProdutoCategoria { get; set; }


        public double CalcularValorTotal()
        {
            // Retorna o cálculo do valor total em estoque
            return PrecoUnitario * QuantidadeEmEstoque;
        }

        public double CalcularImposto()
        {
            // Retorna 40% do preço unitário
            return PrecoUnitario * 0.4;
        }

        public Produto(string nome, double precoUnitario, int quantidade, Categoria categoria)
        {
            TotalProdutos += 1;

            Id = TotalProdutos;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque += quantidade;
            ProdutoCategoria = categoria;
        }

        public static int TotalProdutos { get; set; }
    }
}