/*using Comex.Categorias;
using Comex.Clientes;
using Comex.Pedidos;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaPedidoNotaFiscalEFrete
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

        Console.WriteLine($"Pedidos: \n{pedido1.Id} - {pedido1.Data} Cliente: {pedido1.Cliente.NomeCompleto()} {pedido1.Cliente.CpfCliente.Formatar()}");
        foreach (ItensDoPedido item in pedido1.Itens)
        {
            Console.WriteLine($"{item.Item.Nome} {item.Quantidade} unidades - R${item.Total}");
        }
        Console.WriteLine($"Quantidade Total de Itens: {pedido1.QuantidadeVendida} - Preço Total: R${pedido1.CalculaCustoTotal()}" +
            $"\nImposto: R${pedido1.CalculaTotalImposto()}\nCEP: {pedido1.Cep} - Frete: R${pedido1.FretePedido}");

        Console.WriteLine($"\n{pedido2.Id} - {pedido2.Data} Cliente: {pedido2.Cliente.NomeCompleto()} {pedido2.Cliente.CpfCliente.Formatar()}");
        foreach (ItensDoPedido item in pedido2.Itens)
        {
            Console.WriteLine($"{item.Item.Nome} {item.Quantidade} unidades - R${item.Total}");
        }
        Console.WriteLine($"Quantidade Total de Itens: {pedido2.QuantidadeVendida} - Preço Total: R${pedido2.CalculaCustoTotal()}" +
            $"\nImposto: R${pedido2.CalculaTotalImposto()}\nCEP: {pedido2.Cep} - Frete: R${pedido2.FretePedido}");

        Console.WriteLine($"\n{pedido3.Id} - {pedido3.Data} Cliente: {pedido3.Cliente.NomeCompleto()} {pedido3.Cliente.CpfCliente.Formatar()}");
        foreach (ItensDoPedido item in pedido3.Itens)
        {
            Console.WriteLine($"{item.Item.Nome} {item.Quantidade} unidades - R${item.Total}");
        }
        Console.WriteLine($"Quantidade Total de Itens: {pedido3.QuantidadeVendida} - Preço Total: R${pedido3.CalculaCustoTotal()}" +
            $"\nImposto: R${pedido3.CalculaTotalImposto()}\nCEP: {pedido3.Cep} - Frete: R${pedido3.FretePedido}");

        Console.WriteLine($"\n{pedido4.Id} - {pedido4.Data} Cliente: {pedido4.Cliente.NomeCompleto()} {pedido4.Cliente.CpfCliente.Formatar()}");
        foreach (ItensDoPedido item in pedido4.Itens)
        {
            Console.WriteLine($"{item.Item.Nome} {item.Quantidade} unidades - R${item.Total}");
        }
        Console.WriteLine($"Quantidade Total de Itens: {pedido4.QuantidadeVendida} - Preço Total: R${pedido4.CalculaCustoTotal()}" +
            $"\nImposto: R${pedido4.CalculaTotalImposto()}\nCEP: {pedido4.Cep} - Frete: R${pedido4.FretePedido}");
        Console.WriteLine("---------------------------");

        Console.WriteLine($"Notas Fiscais: \n{pedido1.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido2.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido3.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido4.Nota.GetNotaFiscal()}");
        Console.WriteLine("---------------------------");
    }
}
*/