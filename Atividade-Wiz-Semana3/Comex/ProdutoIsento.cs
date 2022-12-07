using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, double preco_Unitario, double quantidade_Em_Estoque, string categoria) : base(nome, preco_Unitario, quantidade_Em_Estoque, categoria)
        {
        }

        public override double CalculaImposto()
        {
            return 0;
        }
    }
}
