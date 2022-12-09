using Comex.Entidades;

namespace Comex.Testes
{
    public class TestProdutoIsento
    {

        private Categoria categoria = new Categoria("Saude");

        [Fact]
        public void TestaProdutoIsentoInstancia()
        {
            var produto = new ProdutoIsento("Vacina", 100.00, 5, categoria);
            Assert.Equal("SAUDE", produto._categoria.Nome);
            Assert.Equal("Vacina", produto._nome);
            Assert.Equal(100.00, produto._precoUnitario);
            Assert.Equal(5, produto._quantidadeEstoque);
        }

        [Theory]
        [InlineData("Notebook Sansung", 3523.00, 1, "INFORMATICA")]
        [InlineData("Vacina", 102.9, 2, "SAUDE")]
        [InlineData("Manual de Testes", 1889.00, 3, "LIVROS")]

        public void TestaProdutoIsentoInstancias(string nome, double valor, int estoque, string categoria)
        {
            var tipoCategoria = new Categoria(categoria);
            var produto = new ProdutoIsento(nome, valor, estoque, tipoCategoria);
            Assert.Equal(categoria, produto._categoria.Nome);
            Assert.Equal(nome, produto._nome);
            Assert.Equal(valor, produto._precoUnitario);
            Assert.Equal(estoque, produto._quantidadeEstoque);
        }

        [Fact]
        public void TestaProdutoIsentoCalcularValorEstoque()
        {
            var produto = new ProdutoIsento("Vacina", 1000.00, 5, categoria);
            var valorEstoque = produto.CalcularValorEstoque();
            Assert.Equal(5000, valorEstoque);
        }

        [Fact]
        public void TestaProdutoIsentoCalcularImposto()
        {
            var produto = new ProdutoIsento("Vacina", 1000.00, 5, categoria);
            var valorImposto = produto.CalculaImposto();
            Assert.Equal(0, valorImposto);
        }

        [Fact]
        public void TestaListarProdutosIsentos()
        {

            var produto = new ProdutoIsento("Vacina", 1000.00, 5, categoria);
            var listarProduto = produto.ListarProdutos();
            string result = $"Id: {produto._id} - Produto: {produto._nome} - Preço Unitário: R$ {produto._precoUnitario.ToString("n2")}\n" +
                $"Quantidade em Estoque: {produto._quantidadeEstoque} - Categoria: {produto._categoria.Nome}\n" +
                $"Valor total em Estoque: {produto.CalcularValorEstoque().ToString("n2")} - Imposto: {produto.CalculaImposto().ToString("n2")}\n";
            Assert.Equal(result, listarProduto);
        }


    }
}