using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSemana1.ExerciciosSemana1
{
    public class CalculadoraImc
    {
        public static void Calcular()
        {
            Console.Clear();
            Console.WriteLine("\n Calculo do IMC");
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = Math.Round((peso / (altura * altura)) * 10000, 2);
            Console.WriteLine($"Dados informados: Peso: {peso}, Altura: {altura}");
            Console.WriteLine($"Seu IMC é de: {imc}");
            if (imc > 40.0)
            {
                Console.WriteLine("Cuidado! Obesidade Grave");
            }
            else if (imc > 30)
            {
                Console.WriteLine("Cuidado! Obesidade");
            }
            else if (imc > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc > 18.5)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Abaixo do peso");
            }
            Console.WriteLine("\n");
        }
    }
}
