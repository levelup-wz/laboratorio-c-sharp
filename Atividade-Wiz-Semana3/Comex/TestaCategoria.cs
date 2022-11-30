using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaCategoria
    {
        public TestaCategoria() 
        {
            Categoria categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nome = "INFORMÁTICA";
            categoria1.Status = "ATIVA";

            Categoria categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nome = "MÓVEIS";
            categoria2.Status = "INATIVA";

            Categoria categoria3 = new Categoria();
            categoria3.Id = 3;
            categoria3.Nome = "LIVROS";
            categoria3.Status = "ATIVA";

            Console.WriteLine(categoria1.Nome + " (" + categoria1.Id + " - " + categoria1.Status + ")");
            Console.WriteLine(categoria2.Nome + " (" + categoria2.Id + " - " + categoria2.Status + ")");
            Console.WriteLine(categoria3.Nome + " (" + categoria3.Id + " - " + categoria3.Status + ")");
        }
    }
}
