using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");

        static Estoque estoque = new Estoque();

        public static void Main()
        {
            estoque.RegistarEntrada(vacina);
            Console.WriteLine(estoque.RetornarInfosEstoque());
            
        }
    }
}

    