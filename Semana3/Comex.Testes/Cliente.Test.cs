using Comex.Entidades;
using System.Security.Cryptography;

namespace Comex.Testes
{
    public class TestCliente
    {
        private Cliente cliente = new Cliente("Andre", "Sousa", "123456789-88", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia");

        [Fact]
        public void TestaClienteInstancia()
        {
            Assert.Equal("Andre", cliente._nome);
            Assert.Equal("Sousa", cliente._sobreNome);
            Assert.Equal("123456789-88", cliente._cpf);
            Assert.Equal("77988124578", cliente._telefone);
            Assert.Equal("João Alberto", cliente._rua);
            Assert.Equal("12", cliente._numeroEndereco);
            Assert.Equal("Bem querer", cliente._complemento);
            Assert.Equal("Candeias", cliente._bairro);
            Assert.Equal("Salvador", cliente._cidade);
            Assert.Equal("Bahia", cliente._estado);
        }

        [Theory]
        [InlineData("Andre", "Sousa", "123456789-88", "77988124578", "João Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia")]
        [InlineData("Luis", "Jardim", "987654321-88", "77988526341", "Luis ALberto", "13", "Bnh", "Recreio", "Rio de Janeiro", "Rio de Janeiro")]
        [InlineData("Lara", "Jesus", "852963741-88", "77988025698", "Carlos Henrique", "14", "Inocoop", "Centro", "Belo Horizonte", "Minas Gerais")]
        public void TestaCriacaoClientes(string nome, string sobreNome, string cpf, string fone, string rua, string numeroEndereco,
            string complemento, string bairro, string cidade, string estado)
        {
            Cliente novoCliente = new Cliente(nome, sobreNome, cpf, fone, rua, numeroEndereco, complemento, bairro, cidade, estado);

            Assert.Equal(nome, novoCliente._nome);
            Assert.Equal(sobreNome, novoCliente._sobreNome);
            Assert.Equal(cpf, novoCliente._cpf);
            Assert.Equal(fone, novoCliente._telefone);
            Assert.Equal(rua, novoCliente._rua);
            Assert.Equal(numeroEndereco, novoCliente._numeroEndereco);
            Assert.Equal(complemento, novoCliente._complemento);
            Assert.Equal(bairro, novoCliente._bairro);
            Assert.Equal(cidade, novoCliente._cidade);
            Assert.Equal(estado, novoCliente._estado);
        }

        [Fact]
        public void TestaClienteNomeCompleto()
        {
            var nomeCompleto = cliente.NomeCompleto();
            var result = cliente._nome + " " + cliente._sobreNome;
            Assert.Equal(result, nomeCompleto);
        }

        [Fact]
        public void TestaClienteEnderecoCompleto()
        {
            var enderecoCompleto = cliente.EnderecoCompleto();
            var result = $"Rua: {cliente._rua}, nº {cliente._numeroEndereco}, complemento: {cliente._complemento},\n" +
                $"bairro: {cliente._bairro}, cidade: {cliente._cidade}, estado: {cliente._estado}";
            Assert.Equal(result, enderecoCompleto);
        }

        [Fact]
        public void TestaClienteListarCliente()
        {
            var listarCliente = cliente.ListarCliente();
            var result = ($"***** Código do Cliente nº {cliente._id} *****\n" +
                $"Nome: {cliente.NomeCompleto()}\n" +
                $"Endereço: {cliente.EnderecoCompleto()}");
            Assert.Equal(result, listarCliente);
        }

    }
}