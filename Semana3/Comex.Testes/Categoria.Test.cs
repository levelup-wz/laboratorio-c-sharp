using Comex.Entidades;

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

    }
}