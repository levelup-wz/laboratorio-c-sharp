using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models.Lib;

namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 0;
        public int Id { get; set; }
        public DateTime data = DateTime.Now;
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Items { get; set; } = new List<ItemDoPedido>();
        public int QuantidadeVendida { get; set; }

        public Pedido(Cliente cliente)
        {
            Id = ++_id;
            Cliente = cliente;
        }

        public decimal ValorTotal()
        {
            return Items.Sum(i => i.Total);
        }

        public decimal TotalDeImpostos()
        {
            return Items.Sum(i => i.Produto.CalculaImposto());
        }


    }
}
