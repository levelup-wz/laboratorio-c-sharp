using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Produto
    {
        public int Id { get; set; }
        protected string Atributos { get; set; }
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }


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

        public Produto(string nome, double precoUnitario, int quantidade, string categoria)
        {
            TotalProdutos++;

            Id = TotalProdutos;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque += quantidade;
            Categoria = categoria;
        }

        public Produto(int id, string nome, double precoUnitario, int quantidadeEmEstoque, string categoria)
        {

            if (id <= 0)
            {
                throw new ArgumentException("O valor do Id deve ser maior do que 0.");
            }

            if (nome.Length <= 5)
            {
                throw new ArgumentException("O nome deve possuir mais de 5 caracteres.");
            }

            if (precoUnitario <= 0)
            {
                throw new ArgumentException("O preço unitário deve ser maior do que 0.");
            }

            if (quantidadeEmEstoque <= 0)
            {
                throw new ArgumentException("A quantidade em estoque deve ser maior do que 0.");
            }

            if (categoria is null)
            {
                throw new ArgumentException("A categoria deve ser informada.");
            }

            TotalProdutos++;

            Id = id;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            Categoria = categoria;
        }

        public static int TotalProdutos { get; set; }
    }
}