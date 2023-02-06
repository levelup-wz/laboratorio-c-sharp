using Comex.Models;

namespace Comex.TestesUnitarios
{
    public class ItensDoPedidoTeste
    {
        [Fact]
        public void GarantirCalculoTotalPedido()
        {
            //Arange
            var itemsDopedido = new ItensDoPedido(new Produto(nome: "Mesa Gamer", precoUnitario: 418.90M, quantidadeEmEstoque: 50, categoria: "Informática"), quantidade: 3);

            //Act
            decimal total = itemsDopedido.Total;

            //Assert
            Assert.True(total == 1256.7M);
        }
    }
}