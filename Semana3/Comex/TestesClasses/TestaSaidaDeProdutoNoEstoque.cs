using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        public static void Main()
        {
            Categoria saude = new Categoria("saúde");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);

            Estoque estoque = new Estoque();

            Console.WriteLine("\n*************** Testar Saída de Produto no Estoque ***********");

            //estoque.RegistrarEntrada(vacina);
            estoque.ListarEstoque();
            estoque.ResistrarSaida(vacina);
            estoque.ListarEstoque();
        }
    }
}
