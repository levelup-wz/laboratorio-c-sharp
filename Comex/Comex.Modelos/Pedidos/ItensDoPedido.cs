using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Pedidos;

public class ItensDoPedido
{
    public Produto Item { get; }
    public int Quantidade { get; private set; }
    public decimal Total { get; private set; }

    public ItensDoPedido(Produto item, int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade necessária e maior que zero", nameof(quantidade));
        }

        Item = item;
        Quantidade = quantidade;
        Total = item.Preco * quantidade;
    }

    public void AlterarQuantidade(int quantidade)
    {
    }

    public override string ToString()
    {
        return $"\n{Item.Nome} {Quantidade} unidades - R${Total}";
    }
}
