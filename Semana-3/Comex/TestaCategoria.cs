using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaCategoria
    {
        Categoria categoria1 = new Categoria(1, "INFORMÁTICA");
        Categoria categoria2 = new Categoria(2, "MÓVEIS", "INATIVA");
        Categoria categoria3 = new Categoria(3, "LIVROS");

        public TestaCategoria()
        {
            Console.WriteLine(categoria1.Informacoes());
            Console.WriteLine(categoria2.Informacoes());
            Console.WriteLine(categoria3.Informacoes());
        }
    }
}
