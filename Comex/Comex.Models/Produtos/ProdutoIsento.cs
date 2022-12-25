using System;
using Comex.Categorias;

namespace Comex.Produtos
{
    public class ProdutoIsento : Produto
    {
        public static new int Quantidade { get; set; }
        public ProdutoIsento(string nome, string descricao, double preco, int estoque, Categoria categoria)
            : base(nome, descricao, preco, estoque, categoria)
        {
            Quantidade++;
            Id = Quantidade;
        }

        public override double CalculaImposto()
        {
            return 0;
        }
    }
}
