using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        static void Main(string[] args)
        {
            Categoria saude = new Categoria("Saúde");
            Categoria livros = new Categoria("Livros");
            Categoria informatica = new Categoria("Informática");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabecaJava = new ProdutoIsento("Use a cabeça: Java", 112.90, 5, livros);
            Produto macbookPro = new Produto("Macbook Pro", 20000.00, 15, informatica);

            Estoque estoque = new Estoque();
            /*estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(useACabecaJava);
            estoque.RegistraEntrada(macbookPro);

            Console.WriteLine(
                $"ESTOQUE\n" +
                $"Capacidade: {Estoque.Capacidade}\n" +
                $"Ocupação: {Estoque.Ocupacao}\n" +
                $"Montante: {Estoque.Montante:C}\n"
            );
            */

            Produto bala7Belo = new Produto("Bala 7 Belo", 0.1, 5000, new Categoria ("Alimentos"));

            try
            {
                estoque.RegistraEntrada(bala7Belo);
            }
            catch (LimiteDeEstoqueExcedidoException e)
            {
                Console.WriteLine($"ERRO: {e.Message}");
            }
        }
    }
}
