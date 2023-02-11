using Comex.Models;

namespace Comex.TestaModels
{
    public static class TestaProdutoIsento
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 1000, "Saúde");
        static ProdutoIsento livro = new ProdutoIsento(" Use a Cabeça: Java", 112.90, 5, "Livros");
        static Produto computador = new Produto("Macbook Pro", 20000.00, 11, "Informática");

        public static void Main()
        {
            Console.WriteLine($"{vacina.InformacoesDoProduto()} Valor total do produto em estoque:{vacina.ValorTotalEmEstoque():C2}\n Imposto Unidade:{vacina.CalculaImposto():C2}\n");
            Console.WriteLine($"{livro.InformacoesDoProduto()} Valor total do produto em estoque:{livro.ValorTotalEmEstoque():C2}\n Imposto Unidade:{livro.CalculaImposto():C2}\n");
            Console.WriteLine($"{computador.InformacoesDoProduto()} Valor total do produto em estoque:{computador.ValorTotalEmEstoque():C2}\n Imposto Unidade:{computador.CalculaImposto():C2}\n");
        }
    }
}
