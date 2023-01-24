using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaEntradaDeProdutosNoEstoque
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
        static ProdutoIsento livro = new ProdutoIsento(" Use a Cabeça: Java", 112.90, 5, "Livros");
        static Produto computador = new Produto("Macbook Pro", 20000.00, 15, "Informática");
        //static Produto bala = new Produto("Bala 7 Belo", 0.1, 5000, "Alimentos");

        static Estoque estoque = new Estoque();
        
        public static void Main()
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(livro);
            estoque.RegistraEntrada(computador);
            //estoque.RegistraEntrada(bala);
            Console.WriteLine(estoque.InformacoesDoEstoque());
        }
    }
}
