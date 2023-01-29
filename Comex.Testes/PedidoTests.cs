using Comex.Models;
using Comex.Models.Lib;

using Xunit;

namespace Comex.Testes
{
    public class PedidoTests
    {
        private Cliente _cliente;
        public PedidoTests()
        {
            var cpf = new CPF("12312312365");
            _cliente = new Cliente("Meu cliente", "Legal", cpf, "123123", "Rua", "22", string.Empty, "Ferraz", "SP");
        }

        [Fact]
        public void Somar_Valor_Total_Items_Pedido()
        {
            var pedido = new Pedido(_cliente);
            var camisa = new Produto("Camisa", 10, 10, categoria: "Roupas");
            var tenis = new Produto("Tenis", 20, 20, categoria: "Roupas");
            pedido.Items.Add(new ItemDoPedido(camisa, 2));
            pedido.Items.Add(new ItemDoPedido(tenis, 3));

            Assert.Equal(80, pedido.ValorTotal(), 2);

        }

         [Fact]
        public void Somar_Valor_Total_Impostos()
        {
            var pedido = new Pedido(_cliente);
            var camisa = new Produto("Camisa", 10, 10, categoria: "Roupas");
            var tenis = new Produto("Tenis", 20, 20, categoria: "Roupas");
            pedido.Items.Add(new ItemDoPedido(camisa, 2));
            pedido.Items.Add(new ItemDoPedido(tenis, 3));

            Assert.Equal(12, pedido.TotalDeImpostos(), 2);
        }
    }
}
