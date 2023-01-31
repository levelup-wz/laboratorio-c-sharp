using Comex.Modelos.Categorias;
using Comex.Modelos.Clientes;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes;

internal class TestaRemoverItensDoPedido
{
    static Categoria informatica = new("INFORMÁTICA", "ATIVA");
    static Categoria livros = new("LIVROS", "ATIVA");
    static Categoria alimentos = new("ALIMENTOS", "ATIVA");

    static Produto notebook = new("Notebook Samsung", "O melhor da marca!",
        3523.00M, 1, informatica);
    static Produto monitor = new("Monitor Dell", "O melhor da marca!",
        1889.00M, 3, informatica);
    static ProdutoIsento livroJava = new("Use a Cabeça: Java", "Descomplicando Java",
        112.90M, 5, livros);
    static Produto bala = new("Bala 7 Belo", "A mais gostosa", 0.1M, 5000, alimentos);

    static Cliente danilo = new("Danilo", "Siervi", new Cpf("12345678913"), "999999999", "Rua Legal",
    "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

    static ItensDoPedido itens1 = new(notebook, 3);
    static ItensDoPedido itens2 = new(monitor, 4);
    static ItensDoPedido itens3 = new(livroJava, 1);
    static ItensDoPedido itens4 = new(bala, 10);

    static Pedido pedido = new("02/12/2022", danilo, "08532-220", itens1, itens2, itens3, itens4);

    internal static void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Remover Itens do Pedido");
        Console.WriteLine($"\n{pedido}");
        int op = -1;

        while (op != 0)
        {
            Console.WriteLine("Qual item deseja remover? (0 para encerrar)");
            op = int.Parse(Console.ReadLine());
            pedido.RemoverItens(op);

            Console.Clear();
            Console.WriteLine("Testa Remover Itens do Pedido");
            Console.WriteLine($"\n{pedido}");
        }        
        Console.ReadKey();
    }
}
