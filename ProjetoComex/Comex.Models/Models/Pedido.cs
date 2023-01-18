using Comex.Models.Models;
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
        public List<ItemsDoPedido> Items { get; }
        public int QuantidadeVendida { get; }

        public Pedido(Cliente cliente, Produto produto, int quantidadeVendida)
        {
            Items = new List<ItemsDoPedido>();
            var item = new ItemsDoPedido(produto, quantidadeVendida);

            Date = DateTime.Now;
            Cliente = cliente;
            Items.Add(item);
            QuantidadeVendida = quantidadeVendida;
            Id = Pedido.numPedido;
            Pedido.numPedido++;
        }

        public Pedido(Cliente cliente, ItemsDoPedido itemsDoPedido)
        {
            Items = new List<ItemsDoPedido>();

            Date = DateTime.Now;
            Cliente = cliente;
            Items.Add(itemsDoPedido);
            QuantidadeVendida = itemsDoPedido.GetQuantidade();
            Id = Pedido.numPedido;
            Pedido.numPedido++;
        }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;

            foreach (var item in Items)
            {
                valorTotal += item.Total;
            }

            return valorTotal;
        }

        public decimal CalculaImpostoTotal()
        {
            decimal valorTotalImposto = 0;

            foreach (var item in Items)
            {
                valorTotalImposto += (decimal)(QuantidadeVendida * item.Produto.CalculaImposto());
            }

            return valorTotalImposto;
        }

        public void AddItems(Produto produto, int qtdPedido)
        {
            var itemDoPedido = new ItemsDoPedido(produto, qtdPedido);
            Items.Add(itemDoPedido);
        }

        public void RemoveItems(string name)
        {   
            var item = Items.FirstOrDefault(x => x.Produto.Nome == name);

            if (item != null)
            {
                Items.Remove(item);
            }

            if (item == null)
                Console.WriteLine("Produto não Localizado");
        }

        public void UpdateQuantityItemsDoPedido(string name, int quantidade)
        {
            var itemDoPedido = Items.FirstOrDefault(x => x.Produto.Nome == name);
            var produtoDoItem = itemDoPedido.Produto;

            if (itemDoPedido != null)
            {
                Items.Remove(itemDoPedido);
                var newItemDoPedido = new ItemsDoPedido(produtoDoItem, quantidade);
                Items.Add(newItemDoPedido);
            }

            if (itemDoPedido == null)
                Console.WriteLine("Produto não Localizado");
        }

        public string ListarItensDoPedido()
        {
            var itens = "";
            foreach (var item in Items)
            {
                itens += $"Quantidade: {item.GetQuantidade()} - Produto: {item.Produto.Nome} - Valor Unitário: {item.Produto.PrecoUnitario.ToString("n2")} - SubTotal: {item.Total.ToString("n2")}\n";
            }

            return itens;
        }

        public string ListarPedidos()
        {
            return $"***** Pedido nº {Id} *****\n" +
                $"Nome do Cliente: {Cliente.NomeCompleto()}\n" +
                $"Endereço do Cliente: {Cliente.EnderecoCompleto()}\n" +
                $"{ListarItensDoPedido()}" +
                $"Valor Total: R$ {CalcularValorTotal().ToString("n2")}\n" +
                $"Valor do Imposto: {CalculaImpostoTotal().ToString("n2")}";
        }
    }
}
