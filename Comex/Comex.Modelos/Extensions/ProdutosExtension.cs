using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Extensions;

public static class ProdutosExtension
{
    public static Produto EncontrarPeloNome(this List<Produto> list, string nome)
    {
        nome = char.ToUpper(nome[0]) + nome.Substring(1);

        IEnumerable<Produto> produto = (
            from prod in list
            where prod.Nome == nome
            select prod).ToList();

        return produto.First();
    }
}
