/*using Comex.Categorias;
using Comex.Clientes;
using Comex.Pedidos;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaFrete
    {
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria moveis = new Categoria("MÓVEIS", "INATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");

        Produto notebook = new Produto("Notebook Samsung", "O melhor da marca!",
            (decimal)3523.00, 1, informatica);
        Produto cleanA = new Produto("Clean Architecture", "O melhor da marca!",
            (decimal)102.90, 2, livros);
        Produto monitor = new Produto("Monitor Dell", "O melhor da marca!",
            (decimal)1889.00, 3, informatica);

        Cliente danilo = new Cliente("Danilo", "Siervi", new Cpf("12345678913"), "999999999", "Rua Legal",
            "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

        ItensDoPedido itens1 = new ItensDoPedido(notebook, 3);
        ItensDoPedido itens2 = new ItensDoPedido(monitor, 4);
        ItensDoPedido itens3 = new ItensDoPedido(vacina, 100);
        ItensDoPedido itens4 = new ItensDoPedido(vestido, 4);
        ItensDoPedido itens5 = new ItensDoPedido(bala, 10);
        ItensDoPedido itens6 = new ItensDoPedido(livroJava, 2);

        Pedido pedido1 = new Pedido("02/12/2022", danilo, "08532-220", itens1, itens2);
        Pedido pedido2 = new Pedido("03/12/2022", danilo, "83992-332", itens3, itens5, itens6);
        Pedido pedido3 = new Pedido("03/12/2022", danilo, "36623-293", itens4);

        Console.WriteLine($"CEP: {pedido1.Cep} - Frete: R${pedido1.FretePedido}");
        Console.WriteLine($"CEP: {pedido2.Cep} - Frete: R${pedido1.FretePedido}");
        Console.WriteLine($"CEP: {pedido3.Cep} - Frete: R${pedido1.FretePedido}");
    }
}
*/