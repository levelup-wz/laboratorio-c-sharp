using Comex.Entidades;
using System.Security.Cryptography;

namespace Comex.Testes
{
    public class TestPedido
    {

        private Cliente novoCliente = new Cliente("Andre", "Sousa", "12345678988", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia");
        private Categoria categoria = new Categoria("Informatica");
        
        [Fact]
        public void TestaPedidoInstancia()
        {
           
            var produto = new Produto("Computador", 1000.00, 5, categoria);

            var pedido = new Pedido(novoCliente, produto, 2);

            Assert.Equal(pedido.Cliente, novoCliente);
            Assert.Equal(pedido.Items[0].Produto, produto);
            Assert.Equal(2, pedido.QuantidadeVendida);
        }

        [Theory]
        [InlineData("Informática", "Notebook Sansung", 1000.00, 4, 2)]
        [InlineData("Livros", "Clean Architeture", 101.50, 6, 3)]
        [InlineData("Informática", "Monitor Dell", 1000.00, 7, 4)]
        public void TestaPedidoInstancias(string categoria, string produto, double valorProduto, int qtdEstoque, int quantidadePedido)
        {
            var tipoCategoria = new Categoria(categoria);
            var novoProduto = new Produto(produto, valorProduto, qtdEstoque, tipoCategoria);

            var pedido = new Pedido(novoCliente, novoProduto, quantidadePedido);

            Assert.Equal(pedido.Cliente, novoCliente);
            Assert.Equal(pedido.Items[0].Produto, novoProduto);
            Assert.Equal(pedido.QuantidadeVendida, quantidadePedido);
        }

        [Fact]
        public void TestaPedidoCalcularValorTotal()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);
            
            var valorTotal = pedido.CalcularValorTotal();
            var result = pedido.QuantidadeVendida * (decimal)pedido.Items[0].Produto.PrecoUnitario;

            Assert.Equal(result, valorTotal);
        }

        [Fact]
        public void TestaPedidoCalculaImpostoTotal()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);

            var valorImpostoTotal = pedido.CalculaImpostoTotal();
            var result = pedido.QuantidadeVendida * (decimal)pedido.Items[0].Produto.CalculaImposto();

            Assert.Equal(result, valorImpostoTotal);
        }

        [Fact]
        public void TestaPedidoListarPedidos()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);

            var pedidoListarPedido = pedido.ListarPedidos();
            var result = $"***** Pedido nº {pedido.Id} *****\n" +
                $"Nome do Cliente: {pedido.Cliente.NomeCompleto()}\n" +
                $"Endereço do Cliente: {pedido.Cliente.EnderecoCompleto()}\n" +
                $"Produto: {pedido.Items[0].Produto.Nome} - Quantidade: {pedido.QuantidadeVendida} - Categoria: {pedido.Items[0].Produto.Categoria.Nome}\n" +
                $"Valor Total: R$ {pedido.CalcularValorTotal().ToString("n2")}\n" +
                $"Valor do Imposto: {pedido.CalculaImpostoTotal().ToString("n2")}";

            Assert.Equal(result, pedidoListarPedido);
        }




    }
}