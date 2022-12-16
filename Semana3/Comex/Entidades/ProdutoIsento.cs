using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class ProdutoIsento : Produto
    {

        public ProdutoIsento(string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria) : base(nome, precoUnitario, quantidadeEstoque, categoria)
        {
        }

        public ProdutoIsento(int id, string nome, double precoUnitario, int quantidadeEstoque, Categoria categoria) : base(id, nome, precoUnitario, quantidadeEstoque, categoria)
        {
        }

        public override double CalculaImposto()
        {
            return 0;
        }

    }
}
