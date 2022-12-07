using Comex.Entidades;

namespace Comex.Testes
{
    public class TestCategoria
    {
        [Theory]
        [InlineData("INFORMÁTICA", EStatus.Ativa)]
        [InlineData("MÓVEIS", EStatus.Inativa)]
        [InlineData("LIVROS", EStatus.Ativa)]
        public void TestarInstanciasCategoria(string nome, EStatus status)
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
            Assert.Equal(EStatus.Inativa, categoria.Status);
        }

        [Fact]
        public void TestaCategoriaInativa()
        {
            var categoria = new Categoria("categoria de teste", EStatus.Inativa);
            Assert.Equal("CATEGORIA DE TESTE", categoria.Nome);
            Assert.Equal(EStatus.Inativa, categoria.Status);
        }

    }
}