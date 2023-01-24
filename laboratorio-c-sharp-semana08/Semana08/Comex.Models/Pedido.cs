

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Pedido
    {

        //public Produto ProdutoPedido { get; set; } //tipo produto
        public List<ItemsDoPedido> Itens { get; set; }
        public int Id { get; set; }
        public static int ContId = 0;
        public DateTime Data { get; set; }
        // public string Cliente { get; set; }
        public int Quantidade { get; set; }
        public Cliente Cliente { get; set; }

        public Pedido(Cliente cliente,  ItemsDoPedido item, int quantidade)
        {
            Id = ++ContId;
            Cliente = cliente;
            Data = DateTime.Now; 
            //ProdutoPedido = produto;
            Itens = new List<ItemsDoPedido>{item};
            Quantidade= quantidade;
        }

       

        public double ValorPedido() 
        {
             double valorTotal = 0;

            foreach(ItemsDoPedido item in Itens)
            {
                valorTotal += (double)item.Total;
            }
          
            return valorTotal;
        }
                
        public double ImpostoTotal()
        {
            double totalPagar = 0;

            foreach(ItemsDoPedido item in Itens)
            {
                totalPagar += item.Quantidade * item.Produto.Imposto();
            }
            return totalPagar;
        }

        public void RemoveItemPedido(string nome)
        {
            foreach(ItemsDoPedido item in Itens)
            {
                if (item.Produto.Nome == nome)
                {
                    Itens.Remove(item);
                    break;
                }
            }
        }

        public void EditarQuantidadePedido(string nome, int quantidade)
        {
            foreach(ItemsDoPedido item in Itens)
            {
                if (item.Produto.Nome == nome)
                {
                    item.Quantidade = quantidade;
                    break;
                }

            }
        }

        //Teste subsitutuido por teste unitário.
       /* public string RetornaInfosPedido() 
        {
            return $"ID pedido número: {Id} \n" +
                $"{ClientePedido.RetornaCliente()}" +
                $"Data do pedido: {Data.ToString("dd/MM/yyyy")}\n" +
                $"Produto: {ProdutoPedido.Nome}\n" +
                $"Quantidade do pedido: {Quantidade}\n" +
                $"Valor unitário: {ProdutoPedido.PrecoUnitario.ToString("N2")}\n" +
                $"O valor total do pedido R$ {ValorPedido().ToString("N2")}\n" +
                $"Impostos do pedido R$ {ImpostoTotal().ToString("N2")}\n ";
        }*/


    }
}

