using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente ClientePedido { get; set; }
        public Produto PedidoProduto { get; set; }
        public int QuantidadeVendida { get; set; }

        public double CalcularValorTotal()
        {
            return PedidoProduto.PrecoUnitario * QuantidadeVendida;
        }

        public double CalcularImposto()
        {
            return QuantidadeVendida * PedidoProduto.CalcularImposto();
        }

        public Pedido(Cliente cliente, Produto pedidoProduto, int quantidadeVendida) 
        {
            TotalPedidos += 1;

            Id = TotalPedidos;
            Data = DateTime.Now;
            ClientePedido = cliente;
            PedidoProduto = pedidoProduto;
            QuantidadeVendida = quantidadeVendida;
        }

        public static int TotalPedidos { get; set; }
    }
}