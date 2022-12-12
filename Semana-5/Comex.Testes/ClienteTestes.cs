using Comex.Models;
using FluentAssertions;

namespace Comex.Testes
{
    public class ClienteTestes
    {
        Cliente cliente = new Cliente("Saulo", "Alves", "99999999999", "77999999999", "Rua Luva de Pedreiro", "231", "Casa", "Ibotirama", "Bahia");
        [Fact]
        public void NomeCompleto()
        {
            cliente.NomeCompleto().Should().Be($"{cliente.PrimeiroNome} {cliente.Sobrenome}");
        }

        [Fact]
        public void EnderecoCompleto()
        {
            cliente.EnderecoCompleto().Should().Be($" {cliente.Rua}, {cliente.NumeroDoEndereco}, {cliente.Complemento}, {cliente.Cidade} - {cliente.Estado}");

        }
    }
}