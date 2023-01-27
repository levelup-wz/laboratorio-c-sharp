using System;
using Comex.Modelos.Pedidos;

namespace Comex.Testes;

public class TestaFrete
{
    static decimal frete = Frete.Calcular("08532-220");
    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Frete\n");
        Console.WriteLine($"Cep: 08532-220 \nFrete: {frete}");
        Console.ReadKey();
    }
}
