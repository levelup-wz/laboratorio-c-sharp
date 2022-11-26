using System;
class Programa
{
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 1, num3 = 0;

        Console.WriteLine("Sequência de Fibonacci até o vigésimo elemento: ");
        Console.WriteLine(num2);

        for (int i = 0; i​​​​​​​ < 19; i++)
        {
            num3 = num1;
            num1 = num2;
            num2 = num1 + num3;
            Console.WriteLine(num2);
        }

        Console.Write("\n");
        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}