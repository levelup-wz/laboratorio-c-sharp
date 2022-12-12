using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");

        static Estoque estoque = new Estoque();

        public static void Main()
        {
            Console.WriteLine("Entrada do produto");
            estoque.RegistraEntrada(vacina);
            Console.WriteLine(estoque.InformacoesDoEstoque());
            Console.WriteLine("Saída do produto");
            estoque.RegistraSaida(vacina);
            //estoque.RegistraSaida(vacina);
            Console.WriteLine(estoque.InformacoesDoEstoque());
        }
    }
}
