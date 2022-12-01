using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void TestaCategoria(Categoria informatica, Categoria moveis, Categoria livros)
    {
        Console.WriteLine("\n----- TESTE DE CATEGORIA -----\n");

        informatica.ListarCategoria();
        moveis.ListarCategoria();
        livros.ListarCategoria();
    }
}

