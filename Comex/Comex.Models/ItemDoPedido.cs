using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class ItemDoPedido
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; set; }
        public decimal Total => (decimal)Produto.PrecoUnitario * Quantidade;
    }
}
