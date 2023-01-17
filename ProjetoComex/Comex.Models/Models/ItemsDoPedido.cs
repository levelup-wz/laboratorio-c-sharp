using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models;

public class ItemsDoPedido
{
    public Produto Produto { get; }

    public int Quantidade { get; set; }

    public decimal Total { get; } 

    public ItemsDoPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
        Total = (decimal)(Produto.PrecoUnitario * Quantidade);
    }
}

