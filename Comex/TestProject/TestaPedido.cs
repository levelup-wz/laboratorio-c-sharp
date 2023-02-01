using Comex.Modelos.Categorias;
using Comex.Modelos.Clientes;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes;

public class TestaPedido : IDisposable
{
    private Categoria categoria;

    private Produto produto1;
    private Produto produto2;
    private ProdutoIsento produtoIsento;
    private Vestuario vestuario;

    private Cliente cliente;

    private ItensDoPedido itens1;
    private ItensDoPedido itens2;
    private ItensDoPedido itens3;
    private ItensDoPedido itens4;

    private Pedido pedido;

    public TestaPedido()
    {
        categoria = new("Categoria", "ATIVA");

        produto1 = new("Produto", 5M, 20, categoria);
        produto2 = new("Produto", 100M, 20, categoria);
        produtoIsento = new("Produto Isento", 20M, 20, categoria);
        vestuario = new("Produto Vestuário", 50M, 20, categoria, "tamanho=M;cor=Blue");

        cliente = new("Cliente", "Legal", new Cpf("11122233345"), "999999999", "Rua", "Número",
            "Complemento", "Bairro", "Cidade", "Estado");

        itens1 = new(produto1, 10);
        itens2 = new(produto2, 2);
        itens3 = new(produtoIsento, 5);
        itens4 = new(vestuario, 1);

        pedido = new("13/05/2023", cliente, "02345-123", itens1, itens2, itens3, itens4);
    }

    [Fact]
    public void TestaRemoverItens()
    {
        pedido.RemoverItens(2);

        Assert.False(pedido.Itens.Contains(itens2));
        Assert.True(pedido.Itens[2].Id == 3);
    }

    [Fact]
    public void TestaAlterarQuantidade()
    {
        pedido.AlterarQuantidade(3, 10);

        Assert.True(pedido.CalculaValorTotal() == 500M);
        Assert.True(pedido.QuantidadeVendida == 23);
    }

    public void Dispose()
    {
    }
}
