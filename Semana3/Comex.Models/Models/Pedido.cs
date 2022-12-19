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
        public int Id { get; }
        public DateTime Date { get; }
        public Cliente Cliente { get; }
        public Produto Produto { get; }
        public int QuantidadeVendida { get; }

        public Pedido(Cliente cliente, Produto produto, int quantidadeVendida)
        {
            Date = DateTime.Now;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida = quantidadeVendida;
            Id = Pedido.numPedido;
            Pedido.numPedido++;
        }

        public double CalcularValorTotal()
        {
            double valorTotal = QuantidadeVendida * Produto.PrecoUnitario;
            return valorTotal;
        }

        public double CalculaImpostoTotal()
        {
            double valorTotalImposto = QuantidadeVendida * Produto.CalculaImposto();
            return valorTotalImposto;
        }

        public string ListarPedidos()
        {
            return $"***** Pedido nº {Id} *****\n" +
                $"Nome do Cliente: {Cliente.NomeCompleto()}\n" +
                $"Endereço do Cliente: {Cliente.EnderecoCompleto()}\n" +
                $"Produto: {Produto.Nome} - Quantidade: {QuantidadeVendida} - Categoria: {Produto.Categoria.Nome}\n" +
                $"Valor Total: R$ {CalcularValorTotal().ToString("n2")}\n" +
                $"Valor do Imposto: {CalculaImpostoTotal().ToString("n2")}";
        }
    }
}
