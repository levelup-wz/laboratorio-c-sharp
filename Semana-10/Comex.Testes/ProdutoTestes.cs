using Comex.Models;
using Comex.Models.Extensoes;
using FluentAssertions;

namespace Comex.Testes
{
    public class ProdutoTestes
    {
        [Fact]
        public void TestaInformacoesDoProduto()
        {
            Produto produto = new Produto("Notebook Samsung", 3523.00, 1, "Informática");
            produto.InformacoesDoProduto().Should().Be($" Id: {produto.Id}\n Nome: Notebook Samsung\n Preço Unitário: R$ 3.523,00\n Quantidade em Estoque: 1\n Categoria: Informática\n");
        }
        
        [Fact]
        public void TestaValorEmEstoque()
        {
            Produto produto = new Produto("Notebook Samsung", 3523.00, 2, "Informática");
            produto.ValorTotalEmEstoque().Should().Be(7046.00);
        }

        [Fact]
        public void TestaCalculaImposto()
        {
            Produto produto = new Produto("Notebook Samsung", 3523.00, 3, "Informática");
            produto.CalculaImposto().Should().Be(1409.20);
        }

        [Fact]
        public void Deve_encontrar_um_produto_na_lista_pela_descricao()
        {
            List<Produto> produtos = new();
            var camisa = new Produto("Camisa", 10, 10, categoria: "Roupas");
            var tenis = new Produto("Tenis", 20, 20, categoria: "Roupas");
            produtos.AddRange(new[] { camisa, tenis });

            Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
            Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
            Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
        }
    }
}