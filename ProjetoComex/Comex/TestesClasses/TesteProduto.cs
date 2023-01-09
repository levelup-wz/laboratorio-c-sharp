using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class TestaProduto
{
    public static void Main()
    {
        Categoria informatica = new Categoria("informática");
        Categoria livros = new Categoria("livros");

        Produto notebook = new Produto("Notebook Sansung", 3523.00, 1, informatica);
        Produto cleanArchiteture = new Produto("Clean Architeture", 102.90, 2, livros);
        Produto monitor = new Produto("Monitor Dell", 1889.00, 3, informatica);

        Console.WriteLine("\n----- TESTE DE PRODUTO -----\n");

        Console.WriteLine(notebook.ListarProdutos());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine(cleanArchiteture.ListarProdutos());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine(monitor.ListarProdutos());

    }

}
