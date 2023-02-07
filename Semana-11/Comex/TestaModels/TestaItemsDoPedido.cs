using Comex.Models;

namespace Comex.TestaModels;

public static class TestaItemsDoPedido
{
    static Produto produto = new("Computador", 3000.00, 10, "Informática");
    static ItemsDoPedido items = new ItemsDoPedido(produto, 10);

    public static void Main()
    {
        Console.WriteLine($"Total: {items.Total:C}");
    }
}
