using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class ProdutoIsentoteste
    {
       static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250, 1000, "Saúde","");
       static ProdutoIsento use = new ProdutoIsento("Use a cabeça: Java", 112.90, 5, "Livros", "");
       static ProdutoIsento macbook = new ProdutoIsento("Macbook Pro", 20000, 11, "Informático", "");

        public ProdutoIsentoteste ()
        {

            Console.WriteLine(vacina.RetornaInfosProdutoIsento());

            Console.WriteLine(use.RetornaInfosProdutoIsento());

            Console.WriteLine(macbook.RetornaInfosProdutoIsento());
        }

    }
}

