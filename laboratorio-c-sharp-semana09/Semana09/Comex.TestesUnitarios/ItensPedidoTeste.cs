using Comex.Models;


namespace Comex.TestesUnitarios
{
    public class ItensPedidoTeste
    {
        [Fact]
        public void CalcularTotalDoPedido()
        {
            //Arrange
            var itemsDoPedido = new ItemsDoPedido(new Produto("NotBook", 10000, 20, "Informatica", "Preto"),2);

            //Act
            decimal totalPedido = itemsDoPedido.Total;

            //Assert
            Assert.Equal(20000, totalPedido);


        }
    }
}