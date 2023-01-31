using Comex.Modelos.Categorias;
using Comex.Modelos.Exceptions;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes;

public class TestaSaidaDeProdutoNoEstoque
{
    static Categoria saude = new("SAUDE", "ATIVA");
    static Produto vacina = new("Vacina", "Vacinas para todas as doenças",
        250.00M, 500, saude);

    static Estoque estoque = new();

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Saída de Produto no Estoque\n");
        Console.WriteLine(estoque);

        try
        {
            estoque.RegistraEntrada(vacina);
            Console.WriteLine($"\nApós entrada: \n{estoque}");

            estoque.RegistraSaida(vacina);
            Console.WriteLine($"\nApós saída: \n{estoque}");

            estoque.RegistraSaida(vacina);
        }
        catch (LimiteDeEstoqueExcedidoException ex)
        {
            Console.WriteLine($"\nValidação: \nErro do tipo: {ex.Message}");
        }

        Console.ReadKey();
    }
}
