//soma dos números de 1 a 100

using System;
namespace SomarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 1, final = 100, somaNumeros = 0;

            //ir somando os valor de 1 até o 100 para chegar em 5050.

            for (int i = inicio; i <= final; i++)
            {
                somaNumeros = somaNumeros + i;
            }
            Console.WriteLine(String.Format("O resultado da soma é: {0}", somaNumeros));
            Console.ReadKey();
        }
    }
}