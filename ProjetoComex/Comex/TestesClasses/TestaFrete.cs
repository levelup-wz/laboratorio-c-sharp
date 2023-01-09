using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models.Models;

namespace Comex.TestesClasses
{
    public class TestaFrete
    {
        public static void Main()
        {
            var CalculadoraFrete = new Frete();
            var cep1 = CalculadoraFrete.Calcular("45028-674");
            Console.WriteLine($"O Valor do frete para o cep informado é R${cep1}\n");

            var cep2 = CalculadoraFrete.Calcular("35028-674");
            Console.WriteLine($"O Valor do frete para o cep informado é R${cep2}\n");

            var cep3 = CalculadoraFrete.Calcular("08532-220");
            Console.WriteLine($"O Valor do frete para o cep informado é R${cep3}\n");

            var cep4 = CalculadoraFrete.Calcular("65028-674");
            Console.WriteLine($"O Valor do frete para o cep informado é R${cep4}\n");

        }
    }
}
