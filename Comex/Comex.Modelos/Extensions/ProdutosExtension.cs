using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Extensions;

public static class ProdutosExtension
{
    public static Produto EncontrarPeloNome(this List<Produto> list, string nome)
    {
        IEnumerable<Produto> produto = (
            from prod in list
            where prod.Nome.ToLower() == nome.ToLower()
            select prod).ToList();

        return produto.FirstOrDefault();
    }
}
