using Comex.Entidades;
using FluentAssertions;
using System.Runtime.ConstrainedExecution;

namespace Comex.Testes
{
    public class TestCategoria
    {
        [Theory]
        [InlineData("INFORMÁTICA", "Ativa")]
        [InlineData("MÓVEIS", "Inativa")]
        [InlineData("LIVROS", "Ativa")]
        public void TestarInstanciasCategoria(string nome, string status)
        {
            var testeCategoria = new Categoria(nome, status);
            Assert.Equal(nome, testeCategoria.Nome);
            Assert.Equal(status, testeCategoria.Status);
        }
        [Fact]
        public void TestaCategoriaAtiva()
        {
            var categoria = new Categoria("categoria de teste");
            Assert.Equal("CATEGORIA DE TESTE", categoria.Nome);
            Assert.Equal("Ativa", categoria.Status);
        }

        [Fact]
        public void TestaCategoriaInativa()
        {
            var categoria = new Categoria("categoria de teste", "Inativa");
            Assert.Equal("CATEGORIA DE TESTE", categoria.Nome);
            Assert.Equal("Inativa", categoria.Status);
        }

        [Theory(DisplayName = "Teste para lançamentos de exceções na classe Categoria")]
        [InlineData(-1, "Teste de erro ID", "Inativa", "Campo ID deve ser maior que ZERO")]
        [InlineData(12, "Tes", "Ativa", "Campo NOME deve ter mais que 3 caracteres")]
        [InlineData(13, "Teste de Erro Status", "Erro", "Valor do campo STATUS é inválido")]
        public void TestaCategoriaExceptions(int idEntry, string nameEntry, string statusEntry, string errorMessage)
        {
            var categoriaTest = new Categoria(idEntry, nameEntry, statusEntry);
            var act = () => categoriaTest.ValidarCriacao(idEntry, nameEntry, statusEntry);
            act.Should().Throw<ArgumentException>().WithMessage(errorMessage);
        }

    }
}