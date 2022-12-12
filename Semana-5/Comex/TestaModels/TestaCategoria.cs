using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaCategoria
    {
        Categoria categoria1 = new Categoria("INFORMÁTICA");
        Categoria categoria2 = new Categoria("MÓVEIS", "INATIVA");
        Categoria categoria3 = new Categoria("LIVROS");

        public TestaCategoria()
        {
            Console.WriteLine(categoria1.Informacoes());
            Console.WriteLine(categoria2.Informacoes());
            Console.WriteLine(categoria3.Informacoes());
        }
    }
}
