using Comex.Modelos.Categorias;
using System;

namespace Comex.Testes;

public class TestaValidacaoDeCategoria
{
    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Validação de Produtos\n");
        Console.WriteLine("Criando Categoria válida");
        try
        {
            Categoria categoria1 = new Categoria("FILMES", "INATIVA");
            Console.WriteLine("Categoria válida!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
        }

        Console.WriteLine("\nCriando Categoria com status inválido");
        try
        {
            Categoria categoria2 = new Categoria("FILMES", "EM PROCESSAMENTO");
            Console.WriteLine("Categoria válida!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
        }

        Console.WriteLine("\nCriando Categoria com nome inválido");
        try
        {
            Categoria categoria3 = new Categoria("aa", "INATIVA");
            Console.WriteLine("Categoria válida!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
        }

        Console.ReadKey();
    }
}
