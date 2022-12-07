using Comex.Entidades;
using System.Security.Cryptography;

namespace Comex.Testes
{
    public class TestPedido
    {

        private Cliente novoCliente = new Cliente("Andre", "Sousa", "123456789-88", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia");
        private Categoria categoria = new Categoria("Informatica");
        
        [Fact]
        public void TestaPedidoInstancia()
        {
           
            var produto = new Produto("Computador", 1000.00, 5, categoria);

            var pedido = new Pedido(novoCliente, produto, 2);

            Assert.Equal(pedido._cliente, novoCliente);
            Assert.Equal(pedido._produto, produto);
            Assert.Equal(2, pedido._quantidadeVendida);
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

            Assert.Equal(pedido._cliente, novoCliente);
            Assert.Equal(pedido._produto, novoProduto);
            Assert.Equal(pedido._quantidadeVendida, quantidadePedido);
        }

        [Fact]
        public void TestaPedidoCalcularValorTotal()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);
            
            var valorTotal = pedido.CalcularValorTotal();
            var result = pedido._quantidadeVendida * pedido._produto._precoUnitario;

            Assert.Equal(result, valorTotal);
        }

        [Fact]
        public void TestaPedidoCalculaImpostoTotal()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);

            var valorImpostoTotal = pedido.CalculaImpostoTotal();
            var result = pedido._quantidadeVendida * pedido._produto.CalculaImposto();

            Assert.Equal(result, valorImpostoTotal);
        }

        [Fact]
        public void TestaPedidoListarPedidos()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var pedido = new Pedido(novoCliente, produto, 2);

            var pedidoListarPedido = pedido.ListarPedidos();
            var result = $"***** Pedido nº {pedido._id} *****\n" +
                $"Nome do Cliente: {pedido._cliente.NomeCompleto()}\n" +
                $"Endereço do Cliente: {pedido._cliente.EnderecoCompleto()}\n" +
                $"Produto: {pedido._produto._nome} - Quantidade: {pedido._quantidadeVendida} - Categoria: {pedido._produto._categoria.Nome}\n" +
                $"Valor Total: R$ {pedido.CalcularValorTotal().ToString("n2")}\n" +
                $"Valor do Imposto: {pedido.CalculaImpostoTotal().ToString("n2")}";

            Assert.Equal(result, pedidoListarPedido);
        }




    }
}