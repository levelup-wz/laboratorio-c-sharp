using Comex.Models;

namespace Comex.TestesUnitarios
{
    public class ItemsDoPedidoTeste
    {
        [Fact]
        public void GarantirCalculoTotalPedido()
        {
            //Arange
            var itemsDopedido = new ItemsDoPedido(new Produto(id: 50, nome: "Mesa Gamer", preco_Unitario: 418.90, quantidade_Em_Estoque: 50, categoria: "Informática"), quantidade: 3);

            //Act
            decimal total = itemsDopedido.Total;

            //Assert
            Assert.True(total == 1256.7M);
        }
    }
}