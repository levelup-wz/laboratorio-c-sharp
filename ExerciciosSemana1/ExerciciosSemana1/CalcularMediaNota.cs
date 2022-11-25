using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class CalcularMediaNota
    {
        public static void Calcular()
        {
            Console.Clear();
            Console.WriteLine("Calcular média e aprovação da turma\n");

            double notaAna = 6.8;
            double notaBia = 7.9;
            double notaCaio = 6.1;
            double notaDani = 10;
            double notaEli = 5.4;

            double somaDasNotas = notaAna + notaBia + notaCaio + notaDani + notaEli;
            double mediaDasNotas = somaDasNotas / 5;

            Console.WriteLine($"A média da turma foi de: {mediaDasNotas}\n");

            if (mediaDasNotas > 7)
            {
                Console.WriteLine("Turma aprovada!");
            }
            else
            {
                Console.WriteLine("Turma reprovada!");
            }

            Console.WriteLine("\n");
        }
    }
}
