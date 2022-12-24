using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class NotaFiscal
    {
        public int Id { get; }
        internal Pedido Pedido { get; set; }

        public string GerarNotaFiscal()
        {
            return $"Nome do cliente: {Pedido.ClientePedido.PrimeiroNome} {Pedido.ClientePedido.Sobrenome}\n" +
                   $"Data do pedido: {Pedido.Data}\n" +
                   $"Valor total: {Pedido.CalcularValorTotal()}";
        }

        public NotaFiscal(Pedido pedido)
        {
            TotalPedidos += 1;

            Id = TotalPedidos;
            Pedido = pedido;
        }

        public static int TotalPedidos { get; set; }
    }
}
