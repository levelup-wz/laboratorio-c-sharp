using Comex.Models;

namespace Comex.TestaModels;

public class TestaNotaFiscal
{
    static Cpf cpf = new("12345678910");
    static Cliente cliente = new("Saulo", "Alves", cpf, "99999999999", "Lidio", "231", "Casa", "Ibotirama", "Bahia");
    static Produto produto = new("Computador", 3000.00, 10, "Informática");
    static ItemsDoPedido items = new ItemsDoPedido(produto, 10);
    static Pedido pedido = new(cliente, items);
    static NotaFiscal notaFiscal = new(pedido);

    public static void Main()
    {
        Console.WriteLine(notaFiscal.ToString());
    }
}
