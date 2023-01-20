using Comex.Models;
using FluentAssertions;

namespace Comex.Testes
{
    public class PedidoTestes
    {
        static Cliente cliente = new Cliente("Saulo", "Alves Magalhães", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        static Produto produto = new Produto("Notebook Samsung", 3523.00, 1, "Informática");
        Pedido pedido = new Pedido(cliente, produto, 10);
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
