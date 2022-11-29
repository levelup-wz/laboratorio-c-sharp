using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {
        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria(1, "INFORMÁTICA", "INATIVA");
            categoria.Nome.Should().Be("INFORMÁTICA");
            categoria.Status.Should().Be("INATIVA");
        }
    }
}