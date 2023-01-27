using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using Comex.Modelos.Exceptions;
using System;

namespace Comex.Testes;

public class TestaEntradaDeProdutoNoEstoque
{
    static Categoria informatica = new("INFORMÁTICA", "ATIVA");
    static Categoria livros = new("LIVROS", "ATIVA");
    static Categoria saude = new("SAUDE", "ATIVA");

    static ProdutoIsento vacina = new("Vacina", "Vacinas para todas as doenças",
        250.00M, 500, saude);
    static ProdutoIsento livroJava = new("Use a Cabeça: Java", "Descomplicando Java",
        112.90M, 5, livros);
    static Produto macbookPro = new("Macbook pro", "O melhor da marca!",
        20000.00M, 15, informatica);

    static Estoque estoque = new();

    static Categoria alimentos = new("ALIMENTOS", "ATIVA");
    static Produto bala = new("Bala 7 Belo", "A mais gostosa", 0.1M, 5000, alimentos);

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Entrada de Produto no Estoque\n");
        Console.WriteLine(estoque);

        try
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(livroJava);
            estoque.RegistraEntrada(macbookPro);

            Console.WriteLine($"\nApós entrada: \n{estoque}");

            estoque.RegistraEntrada(bala);
        }
        catch (LimiteDeEstoqueExcedidoException ex)
        {
            Console.WriteLine($"\nValidação: \nErro do tipo: {ex.Message}");
        }

        Console.ReadKey();
    }
}
