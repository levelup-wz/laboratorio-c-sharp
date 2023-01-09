using Comex.Entidades;
using FluentAssertions;
using System.Security.Cryptography;

namespace Comex.Testes
{
    public class TestCliente
    {
        private Cliente cliente = new Cliente("Andre", "Sousa", "12345678988", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia");

        [Fact]
        public void TestaClienteInstancia()
        {
            Assert.Equal("Andre", cliente.Nome);
            Assert.Equal("Sousa", cliente.SobreNome);
            Assert.Equal("12345678988", cliente.Cpf.ToString());
            Assert.Equal("77988124578", cliente.Telefone);
            Assert.Equal("João Alberto", cliente.Rua);
            Assert.Equal("12", cliente.NumeroEndereco);
            Assert.Equal("Bem querer", cliente.Complemento);
            Assert.Equal("Candeias", cliente.Bairro);
            Assert.Equal("Salvador", cliente.Cidade);
            Assert.Equal("Bahia", cliente.Estado);
        }

        [Theory]
        [InlineData("Andre", "Sousa", "12345678988", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia")]
        [InlineData("Luis", "Jardim", "98765432188", "77988526341", "Luis ALberto", "13", "Bnh", "Recreio", "Rio de Janeiro", "Rio de Janeiro")]
        [InlineData("Lara", "Jesus", "85296374188", "77988025698", "Carlos Henrique", "14", "Inocoop", "Centro", "Belo Horizonte", "Minas Gerais")]
        public void TestaCriacaoClientes(string nome, string sobreNome, string cpf, string fone, string rua, string numeroEndereco,
            string complemento, string bairro, string cidade, string estado)
        {
            Cliente novoCliente = new Cliente(nome, sobreNome, cpf, fone, rua, numeroEndereco, complemento, bairro, cidade, estado);

            Assert.Equal(nome, novoCliente.Nome);
            Assert.Equal(sobreNome, novoCliente.SobreNome);
            Assert.Equal(cpf, novoCliente.Cpf.ToString());
            Assert.Equal(fone, novoCliente.Telefone);
            Assert.Equal(rua, novoCliente.Rua);
            Assert.Equal(numeroEndereco, novoCliente.NumeroEndereco);
            Assert.Equal(complemento, novoCliente.Complemento);
            Assert.Equal(bairro, novoCliente.Bairro);
            Assert.Equal(cidade, novoCliente.Cidade);
            Assert.Equal(estado, novoCliente.Estado);
        }

        [Fact]
        public void TestaClienteNomeCompleto()
        {
            var nomeCompleto = cliente.NomeCompleto();
            var result = cliente.Nome + " " + cliente.SobreNome;
            Assert.Equal(result, nomeCompleto);
        }

        [Fact]
        public void TestaClienteEnderecoCompleto()
        {
            var enderecoCompleto = cliente.EnderecoCompleto();
            var result = $"Rua: {cliente.Rua}, nº {cliente.NumeroEndereco}, complemento: {cliente.Complemento},\n" +
                $"bairro: {cliente.Bairro}, cidade: {cliente.Cidade}, estado: {cliente.Estado}";
            Assert.Equal(result, enderecoCompleto);
        }

        [Fact]
        public void TestaClienteListarCliente()
        {
            var listarCliente = cliente.ListarCliente();
            var result = ($"***** Código do Cliente nº {cliente.Id} *****\n" +
                $"Nome: {cliente.NomeCompleto()}\n" +
                $"Endereço: {cliente.EnderecoCompleto()}");
            Assert.Equal(result, listarCliente);
        }

        [Theory]
        [InlineData("Jurema", "Tunner", "12345678988", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia")]
        public void TestaCpfCliente(string nome, string sobreNome, string cpfEntry, string fone, string rua, string numeroEndereco,
            string complemento, string bairro, string cidade, string estado)
        {
            var client = new Cliente(nome, sobreNome, cpfEntry, fone, rua, numeroEndereco, complemento, bairro, cidade, estado);
            var cpf = client.Cpf.ToString();
            var cpfFormatado = client.Cpf.Formatar();

            client.Cpf.Cpf.Should().Be(cpfEntry);
            cpf.Should().Be(cpfEntry);
            cpfFormatado.Should().Be("123.456.789-88");

        }

    }
}