using System;
class Programa
{
    static void Main(string[] args)
    {
        int a = 12, b = 3, c = -9;
        double x1, x2, delta;

        delta = Math.Pow(b, 2.0) - 4 * a * c;

        x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine("Resultado das duas raízes da equação: x'= " + x1 + ", x''= " + x2);


        Console.Write("\n");
        Console.WriteLine("Tecle enter para fechar o programa...");
        Console.ReadLine();
    }
}
