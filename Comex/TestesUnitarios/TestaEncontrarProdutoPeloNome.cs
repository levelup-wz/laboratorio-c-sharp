using Comex.Models;
using Comex.Models.Extensoes;

namespace TestesUnitarios
{
    public class TestaEncontrarProdutoPeloNome
    {
        [Fact]
        public void Deve_encontrar_um_produto_na_lista_pela_descricao()
        {
            List<Produto> produtos = new();
            var camisa = new Produto("Camisa", 10, 10, new Categoria("Roupas"));
            var tenis = new Produto("Tenis", 20, 20, new Categoria("Roupas"));
            produtos.AddRange(new[] { camisa, tenis });

            Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
            Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
        }
    }
}