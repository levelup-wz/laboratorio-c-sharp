using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class ProdutoIsento : Produto
    {
        public ProdutoIsento(string nome, double precoUnitario, int quantidadeEmEstoque, string categoria) : base(nome, precoUnitario, quantidadeEmEstoque, categoria)
        {
            
        }

        public override double CalculaImposto()
        {
            return 0;
        }
    }
}
