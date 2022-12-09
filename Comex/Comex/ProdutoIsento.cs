using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class ProdutoIsento : Produto
    {
        public double CalcularImposto()
        {
            return 0;
        }
        public ProdutoIsento(string nome, double precoUnitario, int quantidade, Categoria categoria) : base(nome, precoUnitario, quantidade, categoria)
        {
        }
    }
}
