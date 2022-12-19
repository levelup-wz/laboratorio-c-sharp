using Comex;
using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestaCategoria
{
    public static void Main()
    {
        Categoria informatica = new Categoria("informática");
        Categoria moveis = new Categoria("móveis", "Inativa");
        Categoria livros = new Categoria("livros");

        Console.WriteLine("\n----- TESTE DE CATEGORIA -----\n");

        informatica.ListarCategoria();
        moveis.ListarCategoria();
        livros.ListarCategoria();
    }
}

