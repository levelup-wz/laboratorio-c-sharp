using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        static ProdutoIsento vacina1 = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
        static ProdutoIsento use = new ProdutoIsento("Use a Cabeaça: Java", 112.90, 5, "Livros");
        static Produto macbook = new Produto("Macbook Pro", 20000.00, 15, "Informatica");

        static Estoque estoque2 = new Estoque();

        public static void Main()
        {
            estoque2.RegistarEntrada(vacina1);
            estoque2.RegistarEntrada(use);
            estoque2.RegistarEntrada(macbook);
            Console.WriteLine(estoque2.RetornarInfosEstoque());
            
        }
    }
}

    