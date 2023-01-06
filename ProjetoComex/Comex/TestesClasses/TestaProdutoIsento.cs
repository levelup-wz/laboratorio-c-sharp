using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaProdutoIsento
    {
        public static void Main()
        {
            Categoria informatica = new Categoria("informática");
            Categoria saude = new Categoria("saúde");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 1000, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça", 112.90, 5, livros);
            Produto macbook = new Produto("Macbook", 20000.00, 11, informatica);

            Console.WriteLine("\n*************** Testar produto Isento ***********\n");

            Console.WriteLine(vacina.ListarProdutos());
            Console.WriteLine(useACabeca.ListarProdutos());
            Console.WriteLine(macbook.ListarProdutos());
        }
    }
}
