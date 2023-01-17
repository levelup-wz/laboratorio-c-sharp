using Comex.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaCpf
    {
        public static void Main()
        {
            var cpf = new CPF("11122233355");
            string formatado = cpf.Formatar();
            var igual = formatado == "111.222.333-55";
            Console.WriteLine($"O cpf: {cpf.ToString()} é formatado corretamente: {igual} => {formatado}\n");

            var cpf1 = new CPF("011122233355");
            string formatado1 = cpf1.Formatar();
            var igual1 = formatado1 == "111.222.333-55";
            Console.WriteLine($"O cpf: {cpf1.ToString()} é formatado corretamente: {igual1} => {formatado1}\n");

            var cpf2 = new CPF("1A122233355");
            string formatado2 = cpf2.Formatar();
            var igual2 = formatado2 == "111.222.333-55";
            Console.WriteLine($"O cpf: {cpf2.ToString()} é formatado corretamente: {igual2} => {formatado2}\n");
        }
    }
}
