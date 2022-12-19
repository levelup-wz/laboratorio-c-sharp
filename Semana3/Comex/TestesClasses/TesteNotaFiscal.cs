using Comex.Entidades;
using Comex.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TesteNotaFiscal
    {
        public static void Main()
        {
            Categoria informatica = new Categoria("informática");

            Produto notebook = new Produto("Notebook Sansung", 3523.00, 1, informatica);

            Cliente andre = new Cliente("Andre", "Sousa", "123456789-22", "7798802-0059", "Rua 1", "10", "Bem querer",
                "Candeias", "Vitoria da Conquista", "Bahia");

            Pedido pedido1 = new Pedido(andre, notebook, 2);

            NotaFiscal nota1 = new NotaFiscal(pedido1);
            Console.WriteLine(nota1.ToString());
        }
    }
}
