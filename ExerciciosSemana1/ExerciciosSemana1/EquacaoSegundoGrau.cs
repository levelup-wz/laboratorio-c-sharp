using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class EquacaoSegundoGrau
    {
        public static void Calcular()
        {   
            Console.Clear();
            Console.WriteLine("Calculando a equação de 2º grau");
            Console.Write("Digite o valor da variável a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variável b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variável c: ");
            int c = int.Parse(Console.ReadLine());

            double valueRaiz = Math.Pow(b, 2) - 4 * a * c;
            double raizValue1 = Math.Sqrt(valueRaiz);
            double xPositivo = (-b + raizValue1) / (2 * a);
            double xNegativo = (-b - raizValue1) / (2 * a);
            Console.WriteLine($"As raízes das variáveis a = {a}, b = {b}, c = {c} são: {xPositivo} e {xNegativo}\n");
        }
    }
}
