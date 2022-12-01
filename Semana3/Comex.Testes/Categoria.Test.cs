using Comex.Entidades;

namespace Comex.Testes
{
    public class TestCategoria
    {
        [Theory]
        [InlineData("INFORMÁTICA", "ATIVA")]
        [InlineData("´MÓVEIS", "INATIVA")]
        [InlineData("LIVROS", "ATIVA")]
        public void TestarInstanciasCategoria(string nome, string status)
        {
            var testeCategoria = new Categoria(nome, status);
            Assert.Equal(nome, testeCategoria._nome);
            Assert.Equal(status, testeCategoria._status);
        }
        [Fact]
        public void TestaCategoriaAtiva()
        {
            var categoria = new Categoria("categoria de teste");
            Assert.Equal("CATEGORIA DE TESTE", categoria._nome);
            Assert.Equal("ATIVA", categoria._status);
        }

        [Fact]
        public void TestaCategoriaInativa()
        {
            var categoria = new Categoria("categoria de teste", "inativa");
            Assert.Equal("CATEGORIA DE TESTE", categoria._nome);
            Assert.Equal("INATIVA", categoria._status);
        }

    }
}