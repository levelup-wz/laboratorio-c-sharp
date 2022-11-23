using System;
class Programa
{
    static void Main(string[] args)
    {
        int numero = 100, soma = 0;

        for (int i = 0; i <= numero; i++)
        {
            while (i <= numero)
            {
                soma = soma + i;
                break;
            }
        }

        Console.WriteLine("Soma de todos os números de 1 a 100: " + soma);
        Console.Write("\n");
        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}