using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestaVestuario
    {
        static Vestuario bermuda = new("Moleton", 134, 100, "Bermuda", "tamanho: M; cor: Vermelho");
        static Vestuario camisa = new("Regata", 60, 50, "Camisa", "tamanho: M; cor: Preta");

        //Vestuario adfs = new()

        public static void RetornaVestuario()
        {
            Console.WriteLine($"Tamanho da {bermuda.Categoria}: {bermuda.Tamanho}");
            Console.WriteLine($"Cor da {bermuda.Categoria}: {bermuda.Cor}");
            Console.WriteLine($"Tipo: {bermuda.Nome}");
            Console.WriteLine($"Valor: {bermuda.PrecoUnitario}");
            Console.WriteLine($"Quantidade no Estoque: {bermuda.QuantidadeEmEstoque}" + "\n");



            Console.WriteLine($"Tamanho da {camisa.Categoria}: {camisa.Tamanho}");
            Console.WriteLine($"Cor da {camisa.Categoria}: {camisa.Cor}");
            Console.WriteLine($"Tipo: {camisa.Nome}");
            Console.WriteLine($"Valor: {camisa.PrecoUnitario}");
            Console.WriteLine($"Quantidade no Estoque: {camisa.QuantidadeEmEstoque}" + "\n");
        }
    }
}
