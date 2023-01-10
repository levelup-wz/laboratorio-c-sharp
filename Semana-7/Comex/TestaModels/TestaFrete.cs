using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestaModels
{
    public static class TestaFrete
    {
        static Frete frete = new();

        public static void Main()
        {
            Console.WriteLine($"{frete.Calcular("08532 - 220"):C}");
            Console.WriteLine($"{frete.Calcular("38532 - 220"):C}");
            Console.WriteLine($"{frete.Calcular("48532 - 220"):C}");
            Console.WriteLine($"{frete.Calcular("58532 - 220"):C}");
        }
    }
}
