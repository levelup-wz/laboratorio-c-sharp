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
        static CPF cpf1 = new CPF("12345812985");
        static CPF cpf2 = new CPF("12345885");
        static CPF cpf3 = new CPF("");
        static CPF cpf4 = new CPF("1234581255455985");
        static CPF cpf5 = new CPF("asdddss");


        public static void RetornaCPF()
        {
            string formatado1 = cpf1.Formatar();
            Console.WriteLine($"O CPF formatado é: {formatado1}");
            string formatado2 = cpf2.Formatar();
            Console.WriteLine($"O CPF formatado é: {formatado2}");
           string formatado3 = cpf3.Formatar();
            Console.WriteLine($"O CPF formatado é: {formatado3}");
            string formatado4 = cpf4.Formatar();
            Console.WriteLine($"O CPF formatado é: {formatado4}");
            string formatado5 = cpf5.Formatar();
            Console.WriteLine($"O CPF formatado é: {formatado5}");


        }

    
    }
}
