using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class VerificarNumerosImpares
    {
        public static void CalcularFor()
        {
            Console.Clear();
            Console.WriteLine("Imprimir os números ÍMPARES de 1 a 100 \n");

            Console.WriteLine("Números ímpares no Laço FOR");
            for (int i = 0; i <= 100; i += 1)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\n");
        }

        public static void CalcularWhile()
        {   
            Console.Clear();
            Console.WriteLine("\n Números ímpares no Laço WHILE");
            int j = 0;
            while (j <= 100)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("\n");
        }
    }
}
