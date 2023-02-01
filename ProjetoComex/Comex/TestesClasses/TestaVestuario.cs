using Comex.Entidades;
using Comex.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaVestuario
    {
        public static void Main()
        {
            var vestuario = new Categoria("Vestuario");
            var vestido = new Vestuario("Vestido", 120.00, 10, vestuario, "tamanho: M; cor: Rosa");
            Console.WriteLine($"O atributo tamanho do produto é: {vestido.Tamanho}");
            Console.WriteLine($"O atributo cor do produto é: {vestido.Cor}\n");
            
            var camisa = new Vestuario("Vestido", 120.00, 10, vestuario, "tamanho: G; cor: Vermelho");
            Console.WriteLine($"O atributo tamanho do produto é: {camisa.Tamanho}");
            Console.WriteLine($"O atributo cor do produto é: {camisa.Cor}\n");

            var bermuda = new Vestuario("Vestido", 120.00, 10, vestuario, "tamanho: P; cor: Verde");
            Console.WriteLine($"O atributo tamanho do produto é: {bermuda.Tamanho}");
            Console.WriteLine($"O atributo cor do produto é: {bermuda.Cor}\n");

            var calca = new Vestuario("Calça", 100.00, 5, vestuario, "tamanho: G; cor: Jeans");
            Console.WriteLine($"O atributo tamanho do produto é: {calca.Tamanho}");
            Console.WriteLine($"O atributo cor do produto é: {calca.Cor}\n");
        }
    }
}
