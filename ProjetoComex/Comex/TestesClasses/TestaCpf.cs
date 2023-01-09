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
            Console.WriteLine($"O cpf: {cpf.ToString()} é formatado corretamente: {igual} => {formatado}");
        }
    }
}
