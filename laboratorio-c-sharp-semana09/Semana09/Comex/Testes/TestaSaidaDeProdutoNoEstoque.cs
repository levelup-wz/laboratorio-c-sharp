using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Comex.Exceptions;

namespace Comex.Models
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        static Produto vacina2 = new Produto("Vacina",250.00, 0, "Saúde","");
        static Estoque estoque1 = new Estoque();

        public static void Main()
        {
            try
            {
                estoque1.RegistarEntrada(vacina2);
                Console.WriteLine(estoque1.RetornarInfosEstoque()); //Mostra o estoque depois da entrada da vacina, para o teste de Exceção essa entrada foi de zero.
                estoque1.RegistarSaida(vacina2);
                Console.WriteLine("Após a saída do estoque");
                Console.WriteLine(estoque1.RetornarInfosEstoque());
            }
            catch (LimiteDeEstoqueExcedidoException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }

        }


    }
}

