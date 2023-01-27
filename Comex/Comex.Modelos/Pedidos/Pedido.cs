using System;
using Comex.Modelos.Clientes;

namespace Comex.Modelos.Pedidos
{
    public class Pedido
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Cep { get; private set; }
        public string Data { get; }
        public Cliente Cliente { get; }
        public List<ItensDoPedido> Itens { get; private set; }
        public int QuantidadeVendida { get; private set; }
        public NotaFiscal Nota { get; private set; }
        public decimal FretePedido { get; }

        public Pedido(string data, Cliente cliente, string cep, params ItensDoPedido[] itens)
        {
            Quantidade++;
            Id = Quantidade;
            Itens = new List<ItensDoPedido>();
            Data = data;
            Cliente = cliente;
            QuantidadeVendida = 0;
            Nota = new NotaFiscal(this);
            Cep = cep;
            FretePedido = Frete.Calcular(cep);

            foreach (ItensDoPedido item in itens)
            {
                QuantidadeVendida += item.Quantidade;
                Itens.Add(item);
            }
        }

        public decimal CalculaValorTotal()
        {
            decimal valor = 0;

            foreach (ItensDoPedido item in Itens)
            {
                valor += item.Total;
            }

            return valor;
        }

        public decimal CalculaTotalImposto()
        {
            decimal valor = 0;

            foreach (ItensDoPedido item in Itens)
            {
                valor += item.Item.CalculaImposto() * item.Quantidade;
            }

            return valor;
        }

        public decimal CalculaCustoTotal()
        {
            return CalculaValorTotal() + CalculaTotalImposto() + FretePedido;
        }

        public void RemoverItens(params int[] id)
        {
        }
    }
}
