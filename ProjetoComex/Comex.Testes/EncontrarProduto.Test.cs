using Comex.Entidades;
using Comex.Exceptions;
using Comex.Models.Extensoes;
using FluentAssertions;

namespace Comex.Testes
{
    public class TestLocalizarProduto
    {

        private Categoria roupas = new Categoria("Roupas");

        [Fact]
        public void Deve_encontrar_um_produto_na_lista_pela_descricao()
        {
            List<Produto> produtos = new();
            var camisa = new Produto("Camisa", 10, 10, categoria: roupas);
            var tenis = new Produto("Tenis", 20, 20, categoria: roupas);
            produtos.AddRange(new[] { camisa, tenis });

            Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("camisa").QuantidadeEstoque.Equals(10));
            Assert.True(produtos.EncontrarPeloNome("camisa").GetType().Equals(typeof(Produto)));

            Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
            Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
            Assert.True(produtos.EncontrarPeloNome("tenis").QuantidadeEstoque.Equals(20));
            Assert.True(produtos.EncontrarPeloNome("tenis").GetType().Equals(typeof(Produto)));
            
        }

        
    }
}