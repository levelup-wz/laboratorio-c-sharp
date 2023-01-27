using Comex.Modelos.Clientes;
using System;

namespace Comex.Testes;

public class TestaCpf
{
    static Cpf cpf = new("11122233355");
    static string formatado = cpf.Formatar();

    static bool igual = formatado == "111.222.333-55";

    public static void ExecutarTeste()
    {
        Console.WriteLine($"Cpf formatado: {formatado} \nValidação: {igual}");
    }
}
