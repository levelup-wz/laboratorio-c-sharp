using Comex.Entidades;

namespace Comex.Testes
{
    public class TestProduto
    {

        private Categoria categoria = new Categoria("Informatica");

        [Fact]
        public void TestaProdutoInstancia()
        {
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            Assert.Equal("INFORMATICA", produto._categoria._nome);
            Assert.Equal("Computador", produto._nome);
            Assert.Equal(1000.00, produto._precoUnitario);
            Assert.Equal(5, produto._quantidadeEstoque);
        }

        [Theory]
        [InlineData("Notebook Sansung", 3523.00, 1, "INFORMÁTICA")]
        [InlineData("Clean Architeture", 102.9, 2, "LIVROS")]
        [InlineData("Monitor Dell", 1889.00, 3, "INFORMÁTICA")]
        public void TestaProdutoInstancias(string nome, double valor, int estoque, string categoria)
        {
            var tipoCategoria = new Categoria(categoria);
            var produto = new Produto(nome, valor, estoque, tipoCategoria);
            Assert.Equal(categoria, produto._categoria._nome);
            Assert.Equal(nome, produto._nome);
            Assert.Equal(valor, produto._precoUnitario);
            Assert.Equal(estoque, produto._quantidadeEstoque);
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
            Assert.Equal((produto._precoUnitario * 0.40), valorImposto);
        }

        [Fact]
        public void TestaListarProdutos()
        {
           
            var produto = new Produto("Computador", 1000.00, 5, categoria);
            var listarProduto = produto.ListarProdutos();
            string result = $"Id: {produto._id} - Produto: {produto._nome} - Preço Unitário: R$ {produto._precoUnitario.ToString("n2")}\n" +
                $"Quantidade em Estoque: {produto._quantidadeEstoque} - Categoria: {produto._categoria._nome}\n" +
                $"Valor total em Estoque: {produto.CalcularValorEstoque().ToString("n2")} - Imposto: {produto.CalculaImposto().ToString("n2")}";
            Assert.Equal(result, listarProduto);
        }


    }
}