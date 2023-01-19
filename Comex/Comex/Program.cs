using System;
using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Clientes;
using Comex.Modelos.Exceptions;

class Program
{
    static void Main()
    {
        #region Declarações
        // declaração das categorias
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria moveis = new Categoria("MÓVEIS", "INATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");
        Categoria saude = new Categoria("SAUDE", "ATIVA");
        Categoria alimentos = new Categoria("ALIMENTOS", "ATIVA");
        Categoria roupa = new Categoria("ROUPAS", "ATIVA");

        // declaração dos produtos
        Produto notebook = new Produto("Notebook Samsung", "O melhor da marca!",
            3523.00, 1, informatica);
        Produto cleanA = new Produto("Clean Architecture", "O melhor da marca!",
            102.90, 2, livros);
        Produto monitor = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00, 3, informatica);
        Produto bala = new Produto("Bala 7 Belo", "A mais gostosa", 
            0.1, 5000, alimentos);

        Produto vacina = new ProdutoIsento("Vacina", "Vacinas para todas as doenças",
            250.00, 500, saude);
        Produto livroJava = new ProdutoIsento("Use a Cabeça: Java", "Descomplicando Java",
            112.90, 5, livros);
        Produto macbookPro = new ProdutoIsento("Macbook pro", "O melhor da marca!",
            20000.00, 15, informatica);

        Vestuario vestido = new Vestuario("Vestido rosa", "Bonito",
            249.90, 100, roupa, "tamanho:M;cor:rosa");

        // declaração do cliente
        Cliente danilo = new Cliente("Danilo", "Siervi", new Cpf("12345678913"), "999999999", "Rua Legal",
            "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

        // declaração dos pedidos
        ItensDoPedido itens1 = new ItensDoPedido(notebook, 3);
        ItensDoPedido itens2 = new ItensDoPedido(monitor, 4);
        ItensDoPedido itens3 = new ItensDoPedido(vacina, 100);
        ItensDoPedido itens4 = new ItensDoPedido(vestido, 4);
        ItensDoPedido itens5 = new ItensDoPedido(bala, 10);
        ItensDoPedido itens6 = new ItensDoPedido(livroJava, 2);

        Pedido pedido1 = new Pedido("02/12/2022", danilo, "08532-220", itens1, itens2);
        Pedido pedido2 = new Pedido("03/12/2022", danilo, "83992-332", itens3);
        Pedido pedido3 = new Pedido("03/12/2022", danilo, "36623-293", itens4, itens5);
        Pedido pedido4 = new Pedido("09/12/2022", danilo, "76509-234", itens6);

        // estoque
        Estoque estoque = new Estoque();
        estoque.RegistraEntrada(notebook);
        estoque.RegistraEntrada(cleanA);
        estoque.RegistraEntrada(monitor);
        estoque.RegistraEntrada(vacina);
        estoque.RegistraEntrada(livroJava);
        estoque.RegistraEntrada(macbookPro);
        #endregion

        string op = "";
        while (op != "8")
        {
            Console.Clear();
            
            Console.WriteLine("[1] Ver categorias \n[2] Ver pedidos, frete e notas fiscais \n[3] Conferir estoque \n[4] Teste entrada \n[5] Teste saída \n" +
                "[6] Teste validação de Categorias \n[7] Teste validação de Produtos \n[8] Encerrar");
            op = Console.ReadLine();
            Console.Clear();

            switch (op) 
            {
                #region Testa Categoria, Produto, ProdutoIsento, Vestuario e ItensDoPedido
                case "1":
                    Console.WriteLine($"{informatica.Nome} ({informatica.Id} - {informatica.Status}) \n" +
                        $"{moveis.Nome} ({moveis.Id} - {moveis.Status}) \n{livros.Nome} ({livros.Id} - {livros.Status}) \n" +
                        $"{saude.Nome} ({saude.Id} - {saude.Status}) \n{alimentos.Nome} ({alimentos.Id} - {alimentos.Status}) \n" +
                        $"{roupa.Nome} ({roupa.Id} - {roupa.Status})");
                    string c = Console.ReadLine();
                    Console.Clear();

                    switch (c)
                    {
                        case "1":
                            Console.WriteLine($"Produtos: \n\nCategoria: {notebook.Categoria.Nome} \nId: {notebook.Id} - {notebook.Nome}, {notebook.Descricao} " +
                                $"R${notebook.Preco} \nQuantidade em estoque: {notebook.Estoque} \nImposto R${notebook.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {monitor.Categoria.Nome} \nId: {monitor.Id} - {monitor.Nome}, {monitor.Descricao} R${monitor.Preco}" +
                                $"\nQuantidade em estoque: {monitor.Estoque} \nImposto R${monitor.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {macbookPro.Categoria.Nome} \nId: {macbookPro.Id} - {macbookPro.Nome}, {macbookPro.Descricao} " +
                               $"R${macbookPro.Preco} \nQuantidade em estoque: {macbookPro.Estoque} \nImposto R${macbookPro.CalculaImposto()}");
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.WriteLine("Categoria Inativa");
                            Console.ReadKey();
                            break;

                        case "3":
                            Console.WriteLine($"Produtos: \n\nCategoria: {cleanA.Categoria.Nome} \nId: {cleanA.Id} - {cleanA.Nome}, {cleanA.Descricao} R${cleanA.Preco}" +
                                $"\nQuantidade em estoque: {cleanA.Estoque} \nImposto R${cleanA.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {livroJava.Categoria.Nome} \nId: {livroJava.Id} - {livroJava.Nome}, {livroJava.Descricao} " +
                               $"R${livroJava.Preco} \nQuantidade em estoque: {livroJava.Estoque} \nImposto R${livroJava.CalculaImposto()}");
                            Console.ReadKey();
                            break;

                        case "4":
                            Console.WriteLine($"Produtos: \n\nCategoria: {vacina.Categoria.Nome} \nId: {vacina.Id} - {vacina.Nome}, {vacina.Descricao} R${vacina.Preco}" +
                                $"\nQuantidade em estoque: {vacina.Estoque} \nImposto R${vacina.CalculaImposto()}");
                            Console.ReadKey();
                            break;

                        case "5":
                            Console.WriteLine($"Produtos: \n\nCategoria: {bala.Categoria.Nome} \nId: {bala.Id} - {bala.Nome}, {bala.Descricao} R${bala.Preco}" +
                                $"\nQuantidade em estoque: {bala.Estoque} \nImposto R${bala.CalculaImposto()}");
                            Console.ReadKey();
                            break;

                        case "6":
                            Console.WriteLine($"Produtos: \n\nCategoria: {vestido.Categoria.Nome} \nId: {vestido.Id} - {vestido.Nome}, {vestido.Descricao} " +
                                $"R${vestido.Preco} \nQuantidade em estoque: {vestido.Estoque} \nImposto R${vestido.CalculaImposto()} \nCor: {vestido.Cor} - Tamanho: {vestido.Tamanho}");
                            Console.ReadKey();
                            break;
                    }
                    break;
                #endregion

                #region Testa Pedido, Cliente (Cpf), Nota Fiscal e Frete
                case "2":
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

                    Console.ReadKey();
                    break;
                #endregion

                #region Testa Estoque
                case "3":
                    Console.WriteLine($"Capacidade: {estoque.Capacidade} \nOcupação: {estoque.Ocupacao} \nMontante: {estoque.Montante}");
                    Console.ReadKey();
                    break;
                #endregion

                #region Testa Entrada de Produto no Estoque
                case "4":
                    Estoque testeEstoque1 = new Estoque();

                    testeEstoque1.RegistraEntrada(vacina);
                    testeEstoque1.RegistraEntrada(livroJava);
                    testeEstoque1.RegistraEntrada(macbookPro);

                    Console.WriteLine($"Capacidade: {testeEstoque1.Capacidade} \nOcupação: {testeEstoque1.Ocupacao} \nMontante: {testeEstoque1.Montante} \n\nTeste de validações:");

                    try
                    {
                        testeEstoque1.RegistraEntrada(bala);
                    }
                    catch(LimiteDeEstoqueExcedidoException ex)
                    {
                        Console.WriteLine($"Erro do tipo: {ex.Message}");
                    }

                    Console.ReadKey();
                    break;

                case "5":
                    Estoque testeEstoque2 = new Estoque();

                    testeEstoque2.RegistraEntrada(vacina);
                    Console.WriteLine($"Entrada: \nCapacidade: {testeEstoque2.Capacidade} \nOcupação: {testeEstoque2.Ocupacao} \nMontante: {testeEstoque2.Montante}");

                    testeEstoque2.RegistraSaida(vacina);
                    Console.WriteLine($"\nSaída: \nCapacidade: {testeEstoque2.Capacidade} \nOcupação: {testeEstoque2.Ocupacao} \nMontante: {testeEstoque2.Montante} \n\nTeste de validações:");

                    try
                    {
                        testeEstoque2.RegistraSaida(vacina);
                    }
                    catch(LimiteDeEstoqueExcedidoException ex)
                    {
                        Console.WriteLine($"Erro do tipo: {ex.Message}");
                    }

                    Console.ReadKey();
                    break;
                #endregion

                #region Testa Saida de Produto no Estoque
                case "6":
                    Console.WriteLine("Criando Categoria válida");
                    try
                    {
                        Categoria categoria1 = new Categoria("FILMES", "INATIVA");
                        Console.WriteLine("Categoria válida!");
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
                    }

                    Console.WriteLine("\nCriando Categoria com status inválido");
                    try
                    {
                        Categoria categoria2 = new Categoria("FILMES", "EM PROCESSAMENTO");
                        Console.WriteLine("Categoria válida!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
                    }

                    Console.WriteLine("\nCriando Categoria com nome inválido");
                    try
                    {
                        Categoria categoria3 = new Categoria("aa", "INATIVA");
                        Console.WriteLine("Categoria válida!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Categoria inválida! \nErro do tipo: {ex.Message}");
                    }

                    Console.ReadKey();
                    break;
                #endregion

                #region Testa Validação de Produtos
                case "7":
                    Console.WriteLine("Criando Produto válido: ");
                    try
                    {
                        Produto produto1 = new Produto("produto", "é um produto", 1.44, 20, moveis);
                        Console.WriteLine("Produto válido!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
                    }

                    Console.WriteLine("\nCriando Produto com preço inválido:");
                    try
                    {
                        Produto produto1 = new Produto("produto", "é um produto", 0, 20, moveis);
                        Console.WriteLine("Produto válido!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
                    }

                    Console.WriteLine("\nCriando Produto Isento com estoque inválido:");
                    try
                    {
                        Produto produto1 = new ProdutoIsento("produto", "é um produto", 1.44, -10, moveis);
                        Console.WriteLine("Produto válido!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
                    }

                    Console.WriteLine("\nCriando Produto Isento com categoria nula:");
                    try
                    {
                        Produto produto1 = new ProdutoIsento("produto", "é um produto", 1.44, 20, categoria: null);
                        Console.WriteLine("Produto válido!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
                    }

                    Console.ReadKey();
                    break;
                    #endregion
            }
        }
    }
}
