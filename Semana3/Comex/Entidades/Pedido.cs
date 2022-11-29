using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Pedido
    {
        public static int numPedido = 1;
        public int _id { get; }
        public DateTime _date { get; }
        public Cliente _cliente { get; }
        public Produto _produto { get; }
        public int _quantidadeVendida { get; }

        public Pedido(Cliente cliente, Produto produto, int quantidadeVendida)
        {
            _date = new DateTime();
            _cliente = cliente;
            _produto = produto;
            _quantidadeVendida = quantidadeVendida;
            _id = Pedido.numPedido;
            Pedido.numPedido++;
        }

        public double CalcularValorTotal()
        {
            double valorTotal = _quantidadeVendida * _produto._precoUnitario;
            return valorTotal;
        }

        public double CalculaImpostoTotal()
        {
            double valorTotalImposto = _quantidadeVendida * _produto.CalculaImposto();
            return valorTotalImposto;
        }

        public void ListarPedidos()
        {
            Console.WriteLine($"***** Pedido nº {_id} *****");
            Console.WriteLine($"Nome do Cliente: {_cliente.NomeCompleto()}");
            Console.WriteLine($"Endereço do Cliente: {_cliente.EnderecoCompleto()}");
            Console.WriteLine($"Produto: {_produto._nome} - Quantidade: {_quantidadeVendida} - Categoria: {_produto._categoria._nome}");
            Console.WriteLine($"Valor Total: R$ {CalcularValorTotal().ToString("n2")}");
            Console.WriteLine($"Valor do Imposto: {CalculaImpostoTotal().ToString("n2")}");
        }
    }
}
