using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        static Produto vacina2 = new Produto("Vacina",250.00, 500, "Saúde");
        static Estoque estoque1 = new Estoque();

        public static void Main()
        {
            estoque1.RegistarEntrada(vacina2);
            Console.WriteLine(estoque1.RetornarInfosEstoque());
            estoque1.RegistarSaida(vacina2);
            Console.WriteLine(estoque1.RetornarInfosEstoque());

        }


    }
}

