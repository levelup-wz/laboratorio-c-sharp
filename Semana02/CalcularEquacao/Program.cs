using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)

    {

        double a = 12, b = 3, c = -9;
        double delta, raizDelta, raiz1, raiz2;

        Console.WriteLine("Equação do 2o grau: ax² + bx + cx = 0");

        if(a ==0) // se a = 0 o valor é invalido 
        {
            Console.WriteLine("Valor inavlido");
        }
        if (a != 0) //se diferente de 0 entra nesse bloco
        {
            delta = (b * b) - (4 * a * c); // calculando o delta
            raizDelta= Math.Sqrt(delta); //calculando a raiz de delta
            Console.WriteLine(raizDelta);
            if(delta>=0) //se delta maior ou igual a 0 entra nesse if
            {
                raiz1 = (-b + raizDelta) / (2 * a); // calcula raiz1
                raiz2 = (-b - raizDelta) / (2 * a); //calcula raiz2
                Console.WriteLine("A raiz 1 é: " + raiz1 + " e a raiz 2 é: " + raiz2);
                Console.WriteLine("aeio");
            }
            else //se menor que 0 entra no else e as raizes são complexas
            {
                delta = -delta; 
                raizDelta= Math.Sqrt(delta);
                raiz1 = ((-b) / (2 * a) * (raizDelta) / (2 * a));
                raiz2 = ((-b) / (2 * a) * (raizDelta) / (2 * a));
                Console.WriteLine("A raiz 1 é: " + raiz1 + " e a raiz 2 é: " + raiz2);

            }
        }



        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();


    }
}
