using Comex.Models;

namespace Comex.TestaModels
{
    public class TesteCPF
    {
        static Cpf CPF = new("12345678910");

        public static void Main()
        {
            var cpfFormatado = CPF.Formatar();
            Console.WriteLine($"CPF Formatado: {cpfFormatado}");
            Console.WriteLine($"CPF Sem Formatação: {CPF}");
        }
    }
}
