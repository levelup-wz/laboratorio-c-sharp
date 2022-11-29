using FluentAssertions;

namespace Comex.Testes
{
    public class ProdutoTestes
    {
        [Fact]
        public void TestaInformacoesDoProduto()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática");
            produto.InformacoesDoProduto().Should().Be(" Id: 1\n Nome: Notebook Samsung\n Preço Unitário: 3523\n Quantidade em Estoque: 1\n Categoria: Informática\n");
        }
        
        [Fact]
        public void TestaValorEmEstoque()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática");
            produto.ValorTotalEmEstoque().Should().Be("Valor total do produto em estoque: R$ 3523\n");
        }

        [Fact]
        public void TestaCalculaImposto()
        {
            Produto produto = new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática");
            produto.CalculaImposto().Should().Be("Imposto: R$ 1409,2");
        }
    }
}