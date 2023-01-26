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
            Items = new List<ItemsDoPedido> { item };
        }

        public double ValorTotal()
        {
            var valorTotal = (double)Items.Sum(item => item.Total);
            return valorTotal;
            //double valorTotal = 0;
            //foreach(ItemsDoPedido item in Items)
            //{
            //    valorTotal += (double)item.Total;
            //}
            //return valorTotal;
        }

        public double TotalDeImpostos()
        {
            var totalDeImpostos = Items.Sum(item => item.Quantidade * item.Produto.CalculaImposto());
            return totalDeImpostos;
            //double totalDeImpostos = 0;
            //foreach (ItemsDoPedido item in Items)
            //{
            //    double soma = item.Quantidade * item.Produto.CalculaImposto();
            //    totalDeImpostos += soma;
            //}
            //return (double)totalDeImpostos;
        }

        public void RemoverItemDoPedido(string nome)
        {
            Items.RemoveAll(i => i.Produto.Nome == nome);
        }

        public void EditarQuantidade(string nomeDoItem, int quantidade)
        {
            var item = Items.FirstOrDefault(i => i.Produto.Nome == nomeDoItem); 
            item.Quantidade = quantidade;
        }
    }
}
