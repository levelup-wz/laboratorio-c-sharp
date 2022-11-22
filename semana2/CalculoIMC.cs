using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu peso:");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira sua altura:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine("IMC = " + imc);

        Console.WriteLine("\nAperte enter para encerrar ...");
        Console.ReadLine();
    }
}
