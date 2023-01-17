using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Exceptions;

namespace Comex.Testes
{
    internal class TestaValidacaoDeProdutos
    {
        public static void Main()
        {
            try
            {
                //Produto produto1 = new Produto("Cafeteira", 250, 0, "Eletro");
                ProdutoIsento produto2 = new ProdutoIsento("lit", 100, 10, "Livros","");
              

              // Console.WriteLine($"{produto1.RetornaInfosProduto()}");
               Console.WriteLine($"{produto2.RetornaInfosProduto()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
