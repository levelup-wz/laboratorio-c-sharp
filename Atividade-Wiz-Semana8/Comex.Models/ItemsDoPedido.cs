using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Comex.Models
{
    public class ItemsDoPedido
    {
        public readonly Produto Produto;
        public int Quantidade { get; set; }

        public readonly decimal Total;

        public ItemsDoPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Total = Produto.PrecoUnitario * Quantidade;
        }
    }
}
