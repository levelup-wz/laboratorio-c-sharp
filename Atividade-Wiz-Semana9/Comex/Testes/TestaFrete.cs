using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestaFrete
    {
        static Frete frete0 = new();
        static Frete frete1 = new();
        static Frete frete2 = new();
        static Frete frete3 = new();
        static Frete frete4 = new();
        static Frete frete5 = new();
        static Frete frete6 = new();
        static Frete frete7 = new();
        static Frete frete8 = new();
        static Frete frete9 = new();

        public static void MostraFrete()
        {
            Console.WriteLine($"Dado CEP: 03165-000 Valor do frete: {frete0.Calcular("03165-000")}");
            Console.WriteLine($"Dado CEP: 13165-000 Valor do frete: {frete1.Calcular("13165-000")}");
            Console.WriteLine($"Dado CEP: 23165-000 Valor do frete: {frete2.Calcular("23165-000")}");
            Console.WriteLine($"Dado CEP: 33165-000 Valor do frete: {frete3.Calcular("33165-000")}");
            Console.WriteLine($"Dado CEP: 43165-000 Valor do frete: {frete4.Calcular("43165-000")}");
            Console.WriteLine($"Dado CEP: 53165-000 Valor do frete: {frete5.Calcular("53165-000")}");
            Console.WriteLine($"Dado CEP: 63165-000 Valor do frete: {frete6.Calcular("63165-000")}");
            Console.WriteLine($"Dado CEP: 73165-000 Valor do frete: {frete7.Calcular("73165-000")}");
            Console.WriteLine($"Dado CEP: 83165-000 Valor do frete: {frete8.Calcular("83165-000")}");
            Console.WriteLine($"Dado CEP: 93165-000 Valor do frete: {frete9.Calcular("93165-000")}");
        }
    }
}
