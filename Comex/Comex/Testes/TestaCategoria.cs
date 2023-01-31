using Comex.Modelos.Categorias;
using System;

namespace Comex.Testes;

public class TestaCategoria
{
    static Categoria informatica = new("INFORMÁTICA", "ATIVA");
    static Categoria moveis = new("MÓVEIS", "INATIVA");
    static Categoria livros = new("LIVROS", "ATIVA");

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Categoria\n");
        Console.WriteLine($"{informatica} \n{moveis} \n{livros}");
        Console.ReadKey();
    }
}
