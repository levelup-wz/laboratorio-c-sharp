using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void TestaProduto(Produto notebook, Produto cleanArchiteture, Produto monitor)
    {
        Console.WriteLine("\n----- TESTE DE PRODUTO -----\n");

        Console.WriteLine(notebook.ListarProdutos());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine(cleanArchiteture.ListarProdutos());

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine(monitor.ListarProdutos());

<<<<<<< HEAD
        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine(cadeira.ListarProdutos());

=======
>>>>>>> 58d8a8ce9969f0b7992cb50f2311435a03f69655
    }

}
