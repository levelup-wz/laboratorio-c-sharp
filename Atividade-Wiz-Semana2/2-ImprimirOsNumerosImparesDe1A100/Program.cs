using System;
class Programa
{
    static void Main(string[] args)
    {
        int numero = 100;

        Console.WriteLine("números ímpares de 1 a 100: ");
        for (int i = 0; i <= numero; i++)
        {
            while (i % 2 != 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
        Console.Write("\n");

        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}