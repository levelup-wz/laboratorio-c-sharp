using Comex.Modelos.Clientes;
using System;

namespace Comex.Testes;

public class TestaCpf
{
    static Cpf cpf = new("11122233355");

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Cpf\n");
        Console.WriteLine("Cpf: 11122233355");
        Console.WriteLine($"\nApós formatação: \n{cpf}");
        Console.ReadKey();
    }
}
