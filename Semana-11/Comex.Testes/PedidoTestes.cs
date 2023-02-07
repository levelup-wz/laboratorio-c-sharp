using Comex.Models;
using FluentAssertions;

namespace Comex.Testes
{
    public class PedidoTestes
    {
        static Cliente cliente = new Cliente("Saulo", "Alves Magalhães", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        Pedido pedido = new Pedido(cliente, new ItemsDoPedido(new Produto("Notebook Samsung", 3523.00, 10, "Informática"), 10));
        [Fact]
        public void ValorTotal() 
        {
            pedido.Cliente.PrimeiroNome.Should().Be("Saulo");
            pedido.ValorTotal().Should().Be(35230.00);
        }
        [Fact]
        public void TotalDeImpostos()
        {
            pedido.Cliente.PrimeiroNome.Should().Be("Saulo");
            pedido.TotalDeImpostos().Should().Be(14092.00);
        }
    }
}
