using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Pedido
    {
        private static int _id = 0;
        public int Id { get; set; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; set; }
        public List<ItemsDoPedido> Items { get; set; }

        public Pedido(Cliente cliente, ItemsDoPedido item)
        {
            Id = ++_id;
            Cliente = cliente;
            Items = new List<ItemsDoPedido>();
            Items.Add(item);
        }

        public double ValorTotal()
        {   
            double valorTotal = 0;
            foreach(ItemsDoPedido item in Items)
            {
                valorTotal += (double)item.Total;
            }
            return valorTotal;
        }

        public double TotalDeImpostos()
        {
            double totalDeImpostos = 0;
            foreach (ItemsDoPedido item in Items)
            {
                double soma = item.Quantidade * item.Produto.CalculaImposto();
                totalDeImpostos += soma;
            }
            return (double)totalDeImpostos;
        }
    }
}
