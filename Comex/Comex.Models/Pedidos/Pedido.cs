using System;
using Comex.Produtos;
using Comex.Clientes;
using Comex.Modelos.Pedidos;

namespace Comex.Pedidos
{
    public class Pedido
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Data { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }
        public NotaFiscal Nota { get; private set; }
        public Frete Frete { get; private set; }

        public Pedido(string data, Cliente cliente, Produto produto, int quantidadeVendida, string cep)
        {
            Quantidade++;
            Id = Quantidade;
            Data = data;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida = quantidadeVendida;
            Nota = new NotaFiscal(this);
            Frete = new Frete(cep);
        }

        public double CalculaValorTotal()
        {
            return Produto.Preco * QuantidadeVendida;
        }

        public double CalculaTotalImposto()
        {
            return Produto.CalculaImposto() * QuantidadeVendida;
        }

        public double CalculaCustoTotal()
        {
            return CalculaValorTotal() + CalculaTotalImposto();
        }
    }
}
