using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    internal class ProdutoNaoIsento : Produto
    {
        public ProdutoNaoIsento(string nome, double precoUnitario, int quantidade, string categoria) : base(nome, precoUnitario, quantidade, categoria)
        {
        }


    }
}
