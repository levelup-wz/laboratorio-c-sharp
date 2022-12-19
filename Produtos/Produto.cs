using System;
using Comex.Categorias;

namespace Comex.Produtos
{
    public class Produto
    {
        public static int Quantidade { get; private set; }
        public int Id { get; protected set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }

        public double ValorTotal()
        {
            return Preco * Estoque;
        }
        public virtual double CalculaImposto()
        {
            return 0.4 * Preco;
        }

        public Produto(string nome, string descricao, double preco, int estoque, Categoria categoria)
        {
            Quantidade++;
            Id = Quantidade;
            
            if (nome.Length <= 5)
            {
                throw new ArgumentException("Nome deve ser maior que 5 caracteres");
            }
            if (preco <= 0)
            {
                throw new ArgumentException("Preço obrigatório e não nulo");
            }
            if (estoque <= 0)
            {
                throw new ArgumentException("Estoque obrigatório e não nulo");
            }
            if (categoria == null)
            {
                throw new ArgumentException("Categoria necessária");
            }

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }
    }
}
