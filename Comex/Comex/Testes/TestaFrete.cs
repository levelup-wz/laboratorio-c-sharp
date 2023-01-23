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
            3523.00, 1, informatica);
        Produto cleanA = new Produto("Clean Architecture", "O melhor da marca!",
            102.90, 2, livros);
        Produto monitor = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00, 3, informatica);

        Cliente danilo = new Cliente("Danilo", "Siervi", new Cpf("12345678913"), "999999999", "Rua Legal",
            "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

        Pedido pedido1 = new Pedido("02/12/2022", danilo, notebook, 2, "08532-220");
        Pedido pedido2 = new Pedido("03/12/2022", danilo, cleanA, 2, "83992-332");
        Pedido pedido3 = new Pedido("03/12/2022", danilo, monitor, 1, "36623-293");

        Console.WriteLine($"CEP: {pedido1.Cep} - Frete: R${pedido1.FretePedido}");
        Console.WriteLine($"CEP: {pedido2.Cep} - Frete: R${pedido1.FretePedido}");
        Console.WriteLine($"CEP: {pedido3.Cep} - Frete: R${pedido1.FretePedido}");
    }
}
*/