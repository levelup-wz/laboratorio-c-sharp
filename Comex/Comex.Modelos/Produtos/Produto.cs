using System;
using Comex.Modelos.Categorias;

namespace Comex.Modelos.Produtos
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
        protected string Atributos { get; set; }

        public double ValorTotal()
        {
            return Preco * Estoque;
        }
        public virtual double CalculaImposto()
        {
            return 0.4 * Preco;
        }

        /// <summary>
        /// Cria uma instância de Produto
        /// </summary>
        /// <param name="nome"> <see cref="Nome"/> necessário e maior que 5 caracteres </param>
        /// <param name="descricao"></param>
        /// <param name="preco"> <see cref="Preco"/> obrigatório e diferente de zero </param>
        /// <param name="estoque"> <see cref="Estoque"/> obrigatório e diferente de zero </param>
        /// <param name="categoria"> <see cref="Categoria"/> obrigatória </param>
        /// <exception cref="ArgumentException"></exception>
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
