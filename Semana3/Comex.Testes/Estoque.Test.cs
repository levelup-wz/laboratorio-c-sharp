using Comex.Entidades;

namespace Comex.Testes
{
    public class TestEstoque
    {

        private Estoque estoqueTeste = new Estoque();

        [Fact]
        public void TestaEstoqueInstancia()
        {
            Assert.Equal(1000, estoqueTeste.Capacidade);
        }

        [Theory]
        [InlineData("Notebook Sansung", 1000.00, 100, "INFORMATICA")]
        [InlineData("Vacina", 500.00, 10, "SAUDE")]
        [InlineData("Livro de testes", 10.00, 100, "LIVROS")]

        public void TestaEstoqueVáriasInstâncias(string nome, double valor, int estoque, string categoria)
        {
            var tipoCategoria = new Categoria(categoria);
            var produto = new Produto(nome, valor, estoque, tipoCategoria);
            
            estoqueTeste.RegistrarEntrada(produto);

            Assert.Equal((1000 - produto.QuantidadeEstoque), estoqueTeste.Capacidade);
            Assert.Equal(estoque, estoqueTeste.Ocupacao);
            Assert.Equal(((decimal)produto.CalcularValorEstoque()), estoqueTeste.Montante);
        }

        [Fact]
        public void TestaRegistrarVáriasEntradas()
        {
            Categoria informatica = new Categoria("informática");
            Categoria saude = new Categoria("saúde");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça", 112.90, 5, livros);
            Produto macbook = new Produto("Macbook Pro", 20000.00, 15, informatica);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);
            novoEstoqueTeste.RegistrarEntrada(useACabeca);
            novoEstoqueTeste.RegistrarEntrada(macbook);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque + useACabeca.QuantidadeEstoque + macbook.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque() + (decimal)useACabeca.CalcularValorEstoque() + (decimal)macbook.CalcularValorEstoque()),novoEstoqueTeste.Montante);
        }

        [Fact]
        public void TestaRegistrarSaída()
        {
            Categoria saude = new Categoria("saúde");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça", 112.90, 5, livros);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);
            novoEstoqueTeste.RegistrarEntrada(useACabeca);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque + useACabeca.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque() + (decimal)useACabeca.CalcularValorEstoque()), novoEstoqueTeste.Montante);

            novoEstoqueTeste.ResistrarSaida(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((useACabeca.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)useACabeca.CalcularValorEstoque()), novoEstoqueTeste.Montante);
        }

        [Fact]
        public void TestaZerarEstoque()
        {
            Categoria saude = new Categoria("saúde");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque()), novoEstoqueTeste.Montante);

            novoEstoqueTeste.ResistrarSaida(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal(0, novoEstoqueTeste.Ocupacao);
            Assert.Equal(0, novoEstoqueTeste.Montante);
        }

    }
}