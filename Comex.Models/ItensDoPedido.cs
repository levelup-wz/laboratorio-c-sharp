using Comex.Models;
using Comex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Comex.Models
{
    public class ItensDoPedido
    {
        public Produto Produto { get; private set;}
        public int Quantidade { get; set; }

        public decimal Total;

        public ItensDoPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Total = Produto.Preco * Quantidade;
        }
    }
}
