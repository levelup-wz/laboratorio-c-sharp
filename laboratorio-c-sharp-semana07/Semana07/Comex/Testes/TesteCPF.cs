using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TesteCPF
    {
        static CPF cpf1 = new CPF("12345678985");

        public static void RetornaCPF()
        {
            try
            {
                Console.WriteLine(cpf1);
                Console.WriteLine($"CPF formatado: {cpf1.Formatar} \n");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");

            }
        }

    
    }
}
