using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class SomarUmACem
    {
        public static void CalcularFor()
        {
            Console.Clear();
            Console.WriteLine("Imprimir a soma de 1 a 100 no laço for \n");

            int soma = 0;
            for (int i = 0; i <= 100; i += 1)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números de 1 a 100 no laço FOR é {soma} \n");
        }

        public static void CalcularWhile()
        {
            int somaWhile = 0;
            int count = 0;
            while (count <= 100)
            {
                somaWhile += count;
                count++;
            }
            Console.Clear();
            Console.WriteLine("Imprimir a soma de 1 a 100 no laço WHILE \n");
            Console.WriteLine($"A soma dos números de 1 a 100 no laço WHILE é {somaWhile} \n");
        }
    }
}
