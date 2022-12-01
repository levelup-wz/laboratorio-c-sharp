using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {

        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria("INFORM햀ICA", "INATIVA");
            categoria.Id.Should().Be(1);
            categoria.Nome.Should().Be("INFORM햀ICA");
            categoria.Status.Should().Be("INATIVA");
        }

        [Fact]
        public void TestaInformacoesDaCategoria()
        {
            Categoria categoria = new Categoria("INFORM햀ICA", "INATIVA");
            categoria.Informacoes().Should().Be("INFORM햀ICA (1 - INATIVA)");
        }
    }
}