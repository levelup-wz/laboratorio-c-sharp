using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutosNoEstoque
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
        static ProdutoIsento livro = new ProdutoIsento(" Use a Cabeça: Java", 112.90, 5, "Livros");
        static Produto computador = new Produto("Macbook Pro", 20000.00, 15, "Informática");

        static Estoque estoque = new Estoque();
        
        public static void Main()
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(livro);
            estoque.RegistraEntrada(computador);
            Console.WriteLine(estoque.InformacoesDoEstoque());
        }
    }
}
