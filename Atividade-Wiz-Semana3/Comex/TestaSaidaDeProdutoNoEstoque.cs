using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Comex
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        public static void RegistraSaidoEstoque()
        {
            try
            {
                ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");

                Estoque estoque = new Estoque();

                //estoque.ExibirDadosEstoque();
                //Console.WriteLine("Entrada de Saúde:");
                //estoque.RegistraEntrada(vacina);
                Console.WriteLine("Saída de Saúde:");
                estoque.RegistraSaida(vacina);
                estoque.ExibirDadosEstoque();
                estoque.RegistraSaida(vacina);
            }
            catch (LimiteDeEstoqueExcedidoException ex)
            {
                Console.WriteLine("Ocorreu um erro do tipo LimiteDeEstoqueExcedidoException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
