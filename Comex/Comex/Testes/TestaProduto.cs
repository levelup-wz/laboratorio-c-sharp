using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes;

public class TestaProduto
{
    static Categoria informatica = new("INFORMÁTICA", "ATIVA");
    static Categoria moveis = new("MÓVEIS", "INATIVA");
    static Categoria livros = new("LIVROS", "ATIVA");

    static Produto notebook = new("Notebook Samsung", "O melhor da marca!",
        3523.00M, 1, informatica);
    static Produto cleanA = new("Clean Architecture", "O melhor da marca!",
        102.90M, 2, livros);
    static Produto monitor = new("Monitor Dell", "O melhor da marca!",
        1889.00M, 3, informatica);

    public static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Produto\n");
        Console.WriteLine($"{notebook} \n\n{monitor} \n\n{cleanA}");
        Console.ReadKey();
    }
}
