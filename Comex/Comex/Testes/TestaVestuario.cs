using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes;

public class TestaVestuario
{
    static Categoria roupa = new Categoria("ROUPAS", "ATIVA");

    static Vestuario vestido = new Vestuario("Vestido rosa", "Bonito", 249.90M, 100, roupa, "tamanho:M;cor:rosa");

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Vestuário\n");
        Console.WriteLine(vestido);
        Console.ReadKey();
    }
}
