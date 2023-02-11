using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Pedidos;

public class ItensDoPedido
{
    public ItensDoPedido(Produto item, int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade necessária e maior que zero", nameof(quantidade));
        }

        Item = item;
        Quantidade = quantidade;
    }

    public Produto Item { get; }
    public int Id { get; internal set; }
    public int Quantidade { get; internal set; }
    public decimal Total => Item.Preco * Quantidade;
}
