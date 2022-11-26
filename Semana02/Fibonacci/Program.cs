using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)

    {
        int i = 0;
        int num1 = 0;
        int num2 = 1;
        int fib = 0;
        int j = 0;
        int a = 0, b = 1;

        for (i=1; i<=20; i++) {

            fib = num1; 
            num1 = num2;
            num2 = num1 + fib;
            Console.WriteLine(fib);
        
        }

        Console.WriteLine("Com duas variáveis");

        while(j < 19){
            b = a + b;
            a = b - a;
            Console.WriteLine(a);

            j++;
        }



        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();


    }
}

