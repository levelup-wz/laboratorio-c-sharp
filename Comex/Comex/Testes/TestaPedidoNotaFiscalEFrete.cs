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

        Console.WriteLine($"Pedidos: \n{pedido1.Id} - {pedido1.Data} Cliente: {pedido1.Cliente.NomeCompleto()} {pedido1.Cliente.CpfCliente.Formatar()}" +
            $"\n{pedido1.Produto.Nome} {pedido1.QuantidadeVendida} unidades \nR${pedido1.CalculaValorTotal()}" +
            $" - Imposto: R${pedido1.CalculaTotalImposto()}\nCEP: {pedido1.Cep} - Frete: R${pedido1.FretePedido}");
        Console.WriteLine($"Pedidos: \n{pedido2.Id} - {pedido2.Data} Cliente: {pedido2.Cliente.NomeCompleto()} {pedido2.Cliente.CpfCliente.Formatar()}" +
            $"\n{pedido2.Produto.Nome} {pedido2.QuantidadeVendida} unidades \nR${pedido2.CalculaValorTotal()}" +
            $" - Imposto: R${pedido2.CalculaTotalImposto()}\nCEP: {pedido2.Cep} - Frete: R${pedido2.FretePedido}");
        Console.WriteLine($"Pedidos: \n{pedido3.Id} - {pedido3.Data} Cliente: {pedido3.Cliente.NomeCompleto()} {pedido3.Cliente.CpfCliente.Formatar()}" +
            $"\n{pedido3.Produto.Nome} {pedido3.QuantidadeVendida} unidades \nR${pedido3.CalculaValorTotal()}" +
            $" - Imposto: R${pedido3.CalculaTotalImposto()}\nCEP: {pedido3.Cep} - Frete: R${pedido3.FretePedido}");
        Console.WriteLine("---------------------------");

        Console.WriteLine($"Notas Fiscais: \n{nota1.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido1.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido2.Nota.GetNotaFiscal()}");
        Console.WriteLine($"\n{pedido3.Nota.GetNotaFiscal()}");
    }
}
*/