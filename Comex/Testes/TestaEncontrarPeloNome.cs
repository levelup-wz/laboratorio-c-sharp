using Comex.Modelos.Extensions;
using Comex.Modelos.Produtos;
using Comex.Modelos.Categorias;

namespace UnitTesting;

public class TestaEncontrarPeloNome
{
    [Fact]
    public void Deve_encontrar_um_produto_na_lista_pela_descricao()
    {
        Categoria roupa = new("ROUPA", "ATIVA");
        Produto camisa = new("Camisa", 10M, 10, roupa);
        Produto tenis = new("Tenis", 20M, 20, roupa);

        List<Produto> produtos = new();
        produtos.AddRange(new[] { camisa, tenis });

        Assert.True(produtos.EncontrarPeloNome("Camisa").Nome.Equals("Camisa"));
        Assert.True(produtos.EncontrarPeloNome("camisa").Nome.Equals("Camisa"));
        Assert.True(produtos.EncontrarPeloNome("Tenis").Nome.Equals("Tenis"));
        Assert.True(produtos.EncontrarPeloNome("tenis").Nome.Equals("Tenis"));
    }
}
