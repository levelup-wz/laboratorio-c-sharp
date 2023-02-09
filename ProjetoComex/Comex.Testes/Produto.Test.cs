using Comex.Entidades;
using Comex.Exceptions;
using FluentAssertions;

namespace Comex.Testes
{
    public class TestProduto
    {

        private Categoria categoria = new Categoria("Informatica");

        [Fact]
        public void TestaProdutoInstancia()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            Assert.Equal("INFORMATICA", produto.Categoria.Nome);
            Assert.Equal("Computador", produto.Nome);
            Assert.Equal(1000.00, produto.PrecoUnitario);
            Assert.Equal(5, produto.QuantidadeEstoque);
        }

        [Theory]
        [InlineData("Notebook Sansung", 3523.00, 1, "INFORMÁTICA")]
        [InlineData("Clean Architeture", 102.9, 2, "LIVROS")]
        [InlineData("Monitor Dell", 1889.00, 3, "INFORMÁTICA")]
        public void TestaProdutoInstancias(string nome, double valor, int estoque, string categoria)
        {
            var tipoCategoria = new Categoria(categoria);
            var produto = new Produto(nome, valor, estoque, tipoCategoria);
            Assert.Equal(categoria, produto.Categoria.Nome);
            Assert.Equal(nome, produto.Nome);
            Assert.Equal(valor, produto.PrecoUnitario);
            Assert.Equal(estoque, produto.QuantidadeEstoque);
        }

        [Fact]
        public void TestaProdutoCalcularValorEstoque()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var valorEstoque = produto.CalcularValorEstoque();
            Assert.Equal(5000, valorEstoque);
        }

        [Fact]
        public void TestaProdutoCalcularImposto()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var valorImposto = produto.CalculaImposto();
            Assert.Equal((produto.PrecoUnitario * 0.40), valorImposto);
        }

        [Fact]
        public void TestaListarProdutos()
        {
           
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var listarProduto = produto.ListarProdutos();
            string result = $"Id: {produto.Id} - Produto: {produto.Nome} - Preço Unitário: R$ {produto.PrecoUnitario.ToString("n2")}\n" +
                $"Quantidade em Estoque: {produto.QuantidadeEstoque} - Categoria: {produto.Categoria.Nome}\n" +
                $"Valor total em Estoque: {produto.CalcularValorEstoque().ToString("n2")} - Imposto: {produto.CalculaImposto().ToString("n2")}\n";
            Assert.Equal(result, listarProduto);
        }

        [Theory(DisplayName = "Teste de validação na criação do Produto")]
        [InlineData(0, "nomeProduto", 2.00, 5, "nomeCategoria", "Campo ID deve ser maior que ZERO")]
        [InlineData(1, "tesd", 2.00, 5, "nomeCategoria", "Campo NOME deve ter mais de 5 caracteres")]
        [InlineData(1, "teste preço unitario", 0, 5, "nomeCategoria", "Campo PREÇO UNITÁRIO deve ser maior que ZERO")]
        [InlineData(1, "teste quantidade em estoque", 2, 0, "nomeCategoria", "Campo QUANTIDADE EM ESTOQUE deve ser maior que ZERO")]
        public void TestaValidacaoProdutoException(int idEntry, string nameProductEntry, double priceEntry, int quantityEntry, string categoriaEntry, string messageError)
        {
            var instanceCategory = new Categoria(categoriaEntry);
            var instanceProduct = new Produto(idEntry, nameProductEntry, priceEntry, quantityEntry, instanceCategory);
            var instanceProductIsent = new ProdutoIsento(idEntry, nameProductEntry, priceEntry, quantityEntry, instanceCategory);

            var actProduct = () => instanceProduct.ValidarInformacoes(idEntry, nameProductEntry, priceEntry, quantityEntry, instanceCategory);
            var actProductIsent = () => instanceProduct.ValidarInformacoes(idEntry, nameProductEntry, priceEntry, quantityEntry, instanceCategory);

            instanceCategory.Should().NotBeNull();
            actProduct.Should().Throw<ArgumentException>().WithMessage(messageError);
            actProductIsent.Should().Throw<ArgumentException>().WithMessage(messageError);

        }


    }
}