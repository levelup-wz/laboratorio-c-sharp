using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaValidacaoDeCategoria
    {
        public static void Main()
        {
            try 
            { 
                Categoria categoria1 = new Categoria("INFORMÁTICA", "INATIVA");
                Categoria categoria2 = new Categoria("MÓVEIS");
                Categoria categoria3 = new Categoria("LIVROS", "INATIVA");

                Console.WriteLine(categoria1.Informacoes());
                Console.WriteLine(categoria2.Informacoes());
                Console.WriteLine(categoria3.Informacoes());
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
