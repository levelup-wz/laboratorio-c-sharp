using Comex.Models;
using Comex.Models.Exceptions;

namespace Comex.Testes
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        public static void RegistraSaidoEstoque()
        {
            try
            {
                ProdutoIsento vacina = new("Vacina", 250.00, 500, "Saúde", "");

                Estoque estoque = new();

                //estoque.ExibirDadosEstoque();
                //Console.WriteLine("Entrada de Saúde:");
                //estoque.RegistraEntrada(vacina);
                Console.WriteLine("Saída de Saúde:");
                Estoque.RegistraSaida(vacina);
                Estoque.ExibirDadosEstoque();
                Estoque.RegistraSaida(vacina);
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
