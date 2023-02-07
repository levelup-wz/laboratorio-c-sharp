using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaValidacaoDeProdutos
    {
        public static void Main()
        {
            try
            {
                Produto produto1 = new Produto("Notebook", 3523.00, 1, "Informática");
                ProdutoIsento produto2 = new ProdutoIsento("Clean Architecture", 102.90, 2, "Livros");

                Console.WriteLine($"{produto1.InformacoesDoProduto()} Valor total do produto em estoque:{produto1.ValorTotalEmEstoque():C2}\n Imposto Unidade:{produto1.CalculaImposto():C2}\n");
                Console.WriteLine($"{produto2.InformacoesDoProduto()} Valor total do produto em estoque:{produto2.ValorTotalEmEstoque():C2}\n Imposto Unidade:{produto2.CalculaImposto():C2}\n");
            } 
            catch ( ArgumentException ex )
            {
                Console.WriteLine( ex.Message );
            }
        }
    }
}
