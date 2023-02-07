namespace Comex.Models;

public class ItemsDoPedido
{
    public readonly Produto Produto;
    public int Quantidade { get; set; }

    public decimal Total {
        get { return (decimal)Produto.PrecoUnitario * Quantidade; } 
    }

    public ItemsDoPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }
}