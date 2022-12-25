/*using Comex.Categorias;
using Comex.Clientes;
using Comex.Pedidos;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaPedido
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

        Cliente danilo = new Cliente("Danilo", "Siervi", "12345678913", "32998145012", "Rua Legal",
            "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

        Pedido pedido1 = new Pedido("02/12/2022", danilo, notebook, 2);
        Pedido pedido2 = new Pedido("03/12/2022", danilo, cleanA, 2);
        Pedido pedido3 = new Pedido("03/12/2022", danilo, monitor, 1);

        Console.WriteLine($"Pedidos: \n{pedido1.Id} - {pedido1.Data} Cliente: {pedido1.Cliente.NomeCompleto()} \n{pedido1.Produto.Nome} " +
            $"{pedido1.QuantidadeVendida} unidades \nR${pedido1.CalculaValorTotal()} - Imposto: R${pedido1.CalculaTotalImposto()}");
        Console.WriteLine($"\n{pedido2.Id} - {pedido2.Data} Cliente: {pedido2.Cliente.NomeCompleto()} \n{pedido2.Produto.Nome} " +
            $"{pedido2.QuantidadeVendida} unidades \nR${pedido2.CalculaValorTotal()} - Imposto: R${pedido2.CalculaTotalImposto()}");
        Console.WriteLine($"\n{pedido3.Id} - {pedido3.Data} Cliente: {pedido3.Cliente.NomeCompleto()} \n{pedido3.Produto.Nome} " +
            $"{pedido3.QuantidadeVendida} unidades \nR${pedido3.CalculaValorTotal()} - Imposto: R${pedido3.CalculaTotalImposto()}");
        Console.WriteLine("---------------------------");

        Console.WriteLine($"Notas Fiscais: \n{nota1.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido1.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido2.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido3.Nota.GetNotaFiscal()}");
    }
}
*/
