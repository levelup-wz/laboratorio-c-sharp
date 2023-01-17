using Comex.Entidades;
using Comex.Models.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TesteItemsDoPedido
    {
        [Theory]
        [InlineData("Informática", "Monitor", 300.00, 5, 3, 900.00)]
        [InlineData("Livros", "A ida dos que não foram", 21.00, 3, 2, 42.00)]
        public void TestaNewItemsDoPedidoSuccess(string categoryEntry, string ProdutoNameEntry, double ProdutoPreco, int ProdutoQuantidade, int quantidadePedido, decimal totalItemsPedido)
        {
            var categoria = new Categoria(categoryEntry);
            var produto = new Produto(ProdutoNameEntry, ProdutoPreco, ProdutoQuantidade, categoria);
            var itemsDoPedido = new ItemsDoPedido(produto, quantidadePedido);

            itemsDoPedido.Should().NotBeNull();
            itemsDoPedido.Produto.Should().BeSameAs(produto);
            itemsDoPedido.Produto.Nome.Should().Be(ProdutoNameEntry);
            itemsDoPedido.Total.Should().Be(totalItemsPedido);

        }
    }
}
