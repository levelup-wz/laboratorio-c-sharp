using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 12;
        int b = 3;
        int c = -9;

        double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

        Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);

        Console.WriteLine("\nAperte enter para encerrar ...");
        Console.ReadLine();
    }
}
