using Comex.Models;
using Comex.Models.Exceptions;

namespace Comex.Testes
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        public static void RegistraEntradoEstoque()
        {
            try
            {
                ProdutoIsento vacina = new("Vacina", 250.00, 500, "Saúde", "");
                ProdutoIsento useACabeca = new("Use a Cabeça: Java", 112.90, 5, "Livros", "");
                Produto macbook = new("Macbook Pro", 20000.00, 15, "Informática", "");
                Produto Bala7Belo = new("Bala 7 Belo", 0.1, 5000, "Alimentos", "");

                Estoque estoque = new();

                Estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Saúde:");
                Estoque.RegistraEntrada(vacina);
                Estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Livros:");
                Estoque.RegistraEntrada(useACabeca);
                Estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Informática:");
                Estoque.RegistraEntrada(macbook);
                Estoque.ExibirDadosEstoque();
                Console.WriteLine("Entrada de Alimentos:");
                Estoque.RegistraEntrada(Bala7Belo);
                Estoque.ExibirDadosEstoque();
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
