using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        static void Main(string[] args)
        {
            Categoria saude = new Categoria("Saúde");
            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);

            Estoque estoque = new Estoque();

            /*estoque.RegistraEntrada(vacina);
            Console.WriteLine(
                $"ESTOQUE - REGISTRO DE ENTRADA\n" +
                $"Capacidade: {Estoque.Capacidade}\n" +
                $"Ocupação: {Estoque.Ocupacao}\n" +
                $"Montante: {Estoque.Montante:C}\n"
            );

            estoque.RegistraSaida(vacina);
            Console.WriteLine(
                $"ESTOQUE - REGISTRO DE SAÍDA\n" +
                $"Capacidade: {Estoque.Capacidade}\n" +
                $"Ocupação: {Estoque.Ocupacao}\n" +
                $"Montante: {Estoque.Montante:C}\n"
            );*/

            try
            {
                estoque.RegistraSaida(vacina);
            }
            catch (LimiteDeEstoqueExcedidoException e)
            {
                Console.WriteLine($"ERRO: {e.Message}");
            }
        }
    }
}
