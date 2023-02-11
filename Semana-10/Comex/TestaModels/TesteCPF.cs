using Comex.Models;

namespace Comex.TestaModels
{
    public class TesteCPF
    {
        public static Cpf CPF { get; set; }
        public static void Main()
        {
            try
            {
                Cpf cpf = new("12345678910");
                CPF = cpf;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            var cpfFormatado = CPF.Formatar();
            Console.WriteLine($"CPF Formatado: {cpfFormatado}");
            Console.WriteLine($"CPF Sem Formatação: {CPF}");
        }
    }
}
