using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaVestuario
    {
        static Vestuario camiseta = new("Camiseta Lacoste", 120.00, 10, "VESTUÁRIO", "tamanho: P; cor: Preta");

        public static void Main()
        {
            Console.WriteLine($"Tamanho da camiseta: {camiseta.Tamanho}");
            Console.WriteLine($"Cor da camiseta: {camiseta.Cor}");
        }
    }
}
