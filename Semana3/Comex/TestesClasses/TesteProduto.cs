using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void TestaProduto(Produto notebook, Produto cleanArchiteture, Produto monitor, Produto cadeira)
    {
        Console.WriteLine("\n----- TESTE DE PRODUTO -----\n");

        notebook.ListarProdutos();

        Console.WriteLine("\n----------------------------------\n");

        cleanArchiteture.ListarProdutos();

        Console.WriteLine("\n----------------------------------\n");

        monitor.ListarProdutos();

        Console.WriteLine("\n----------------------------------\n");

        cadeira.ListarProdutos();

    }

}
