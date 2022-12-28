using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    internal class TestaValidacaoDeCategoria
    {
        public static void Main()
        {


            try
            {
                Categoria categoria1 = new Categoria("livros", "aer");



            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

