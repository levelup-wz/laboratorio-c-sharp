using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class Fibonacci
    {
        public static void CalcularFibonacciComFor()
        {
            Console.Clear();
            Console.WriteLine("Sequência Fibonacci com FOR");
            int fiboA = 0;
            int fiboB = 1;
            int fiboSoma;

            for (int i = 0; i < 20; i += 1)
            {
                fiboSoma = fiboA + fiboB;
                fiboA = fiboB;
                fiboB = fiboSoma;
                Console.WriteLine(fiboA);
            }

        }

        public static void CalcularFibonacciComWhile()
        {
            Console.Clear();
            Console.WriteLine("\n Sequência Fibonacci com WHILE");
            int fiboAw = 0;
            int fiboBw = 1;
            int fiboSomaw;
            int count = 0;

            while (count < 20)
            {
                fiboSomaw = fiboAw + fiboBw;
                fiboAw = fiboBw;
                fiboBw = fiboSomaw;
                Console.WriteLine(fiboAw);
                count++;
            }
        }

        public static void CalcularFibonacciComForDuasVariaveis()
        {
            Console.Clear();
            Console.WriteLine(" \n Sequência Fibonacci com FOR com 2 variáveis");
            int fiboForA = 1;
            int fiboForSoma = 0;

            for (int i = 0; i <= 20; i += 1)
            {
                fiboForSoma += fiboForA;
                fiboForA = fiboForSoma - fiboForA;
                Console.WriteLine(fiboForA);
            }
        }
    }
}
