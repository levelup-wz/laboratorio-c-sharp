using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    internal class TestaVestuario
    {
        static Vestuario camiseta = new("Algodão", 65, 37, "Camiseta", "tamanho: M; cor: Rosa");
       

        public static void RetornaVestuario()
        {
            Console.WriteLine($"Tamanho da {camiseta.Categoria}: {camiseta.Tamanho}");
            Console.WriteLine($"Cor da {camiseta.Categoria}: {camiseta.Cor}");
    }   }
}
