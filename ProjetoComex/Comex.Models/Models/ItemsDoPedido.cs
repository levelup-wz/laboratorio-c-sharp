using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models;

public class ItemsDoPedido
{
    public Produto Produto { get; }

    private int Quantidade { get; set; }

    public decimal Total => (decimal)(Quantidade * Produto.PrecoUnitario);

    public ItemsDoPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public void UpdateQuantidade(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade = quantidade;
        }
    }

    public int GetQuantidade()
    {
        return Quantidade;
    }

}

