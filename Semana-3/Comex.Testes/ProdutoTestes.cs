using FluentAssertions;

namespace Comex.Testes
{
    public class ProdutoTestes
    {
        [Fact]
        public void TestaInformacoesDoProduto()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática");
            produto.InformacoesDoProduto().Should().Be(" Id: 1\n Nome: Notebook Samsung\n Preço Unitário: R$ 3.523,00\n Quantidade em Estoque: 1\n Categoria: Informática\n");
        }
        
        [Fact]
        public void TestaValorEmEstoque()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 2, "Informática");
            produto.ValorTotalEmEstoque().Should().Be(7046.00);
        }

        [Fact]
        public void TestaCalculaImposto()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 3, "Informática");
            produto.CalculaImposto().Should().Be(1409.20);
        }
    }
}