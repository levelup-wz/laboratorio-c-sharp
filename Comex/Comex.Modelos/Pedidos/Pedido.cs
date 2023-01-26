using System;
using Comex.Modelos.Clientes;

namespace Comex.Modelos.Pedidos
{
    public class Pedido
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Cep { get; private set; }
        public string Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensDoPedido> Itens { get; set; }
        public int QuantidadeVendida { get; set; }
        public NotaFiscal Nota { get; private set; }
        public decimal FretePedido { get; private set; }

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

        public void RemoverItens(int id)
        {
            IEnumerable<ItensDoPedido> itens = (
                from item in Itens
                where item.Item.Id == id
                select item).ToList();

            if (itens == null)
            {
                throw new ArgumentNullException("Item não existente no pedido");
            }
        }
    }
}
