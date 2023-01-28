using Comex.Modelos.Categorias;
using Comex.Modelos.Extensions;
using Comex.Modelos.Produtos;
using System;
using Xunit;

namespace Comex.Testes;

internal class TestaEncontrarPeloNome
{
    static Categoria roupa = new("ROUPA", "ATIVA");

    static List<Produto> produtos = new();

    static Produto camisa = new("Camisa", 10M, 10, roupa);
    static Produto tenis = new("Tenis", 20M, 20, roupa);

    [Fact]
    public void ExecutarTeste()
    {
        Console.Clear();
        Console.WriteLine("Testa Encontrar Pelo Nome");
        produtos.AddRange(new[] { camisa, tenis });
        Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
        Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
        Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
        Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
        Console.ReadKey();
    }
}
