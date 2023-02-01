using System;
using Comex.Modelos.Categorias;

namespace Comex.Modelos.Produtos;

public class ProdutoIsento : Produto
{
    public static new int Quantidade { get; private set; }

    public ProdutoIsento(string nome, decimal preco, int estoque, Categoria categoria)
        : base(nome, preco, estoque, categoria)
    {
        Quantidade++;
        Id = Quantidade;
    }

    public override decimal CalculaImposto()
    {
        return 0;
    }
}
