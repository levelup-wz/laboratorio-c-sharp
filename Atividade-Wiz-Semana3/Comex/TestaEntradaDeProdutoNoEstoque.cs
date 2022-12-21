using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Comex.Models;

namespace Comex
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        public static void RegistraEntradoEstoque()
        {
            try
            {
                ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
                ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça: Java", 112.90, 5, "Livros");
                Produto macbook = new Produto("Macbook Pro", 20000.00, 15, "Informática");
                Produto Bala7Belo = new Produto("Bala 7 Belo", 0.1, 5000, "Alimentos");

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
                Console.WriteLine("Entrada de Alimentos:");
                estoque.RegistraEntrada(Bala7Belo);
                estoque.ExibirDadosEstoque();
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
