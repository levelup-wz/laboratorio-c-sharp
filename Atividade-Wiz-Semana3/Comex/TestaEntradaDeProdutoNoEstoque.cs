using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        public static void RegistraEntradaEstoque()
        {
            try
            {
                ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
                ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça: Java", 112.90, 5, "Livros");
                Produto macbook = new Produto("Macbook Pro", 20000.00, 15, "Informática");

                Estoque estoque = new Estoque();

                estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Saúde:");
                estoque.RegistraEntrada(vacina);
                estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Livros:");
                estoque.RegistraEntrada(useACabeca);
                estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Informática:");
                estoque.RegistraEntrada(macbook);
                estoque.ExibirDadosEstoque();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
