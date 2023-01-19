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

        Pedido pedido1 = new Pedido("02/12/2022", danilo, notebook, 2, "08532-220");
        Pedido pedido2 = new Pedido("03/12/2022", danilo, cleanA, 2, "83992-332");
        Pedido pedido3 = new Pedido("03/12/2022", danilo, monitor, 1, "36623-293");
        Pedido pedido4 = new Pedido("09/12/2022", danilo, vacina, 200, "76509-234");

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
                #region Testa Categoria, Produto, ProdutoIsento e Vestuario
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
                    Console.WriteLine($"Pedidos: \n{pedido1.Id} - {pedido1.Data} Cliente: {pedido1.Cliente.NomeCompleto()} {pedido1.Cliente.CpfCliente.Formatar()}" +
                        $"\n{pedido1.Produto.Nome} {pedido1.QuantidadeVendida} unidades \nR${pedido1.CalculaValorTotal()}" +
                        $" - Imposto: R${pedido1.CalculaTotalImposto()}\nCEP: {pedido1.Cep} - Frete: R${pedido1.FretePedido}");
                    Console.WriteLine($"Pedidos: \n{pedido2.Id} - {pedido2.Data} Cliente: {pedido2.Cliente.NomeCompleto()} {pedido2.Cliente.CpfCliente.Formatar()}" +
                        $"\n{pedido2.Produto.Nome} {pedido2.QuantidadeVendida} unidades \nR${pedido2.CalculaValorTotal()}" +
                        $" - Imposto: R${pedido2.CalculaTotalImposto()}\nCEP: {pedido2.Cep} - Frete: R${pedido2.FretePedido}");
                    Console.WriteLine($"Pedidos: \n{pedido3.Id} - {pedido3.Data} Cliente: {pedido3.Cliente.NomeCompleto()} {pedido3.Cliente.CpfCliente.Formatar()}" +
                        $"\n{pedido3.Produto.Nome} {pedido3.QuantidadeVendida} unidades \nR${pedido3.CalculaValorTotal()}" +
                        $" - Imposto: R${pedido3.CalculaTotalImposto()}\nCEP: {pedido3.Cep} - Frete: R${pedido3.FretePedido}");
                    Console.WriteLine($"Pedidos: \n{pedido4.Id} - {pedido4.Data} Cliente: {pedido4.Cliente.NomeCompleto()} {pedido4.Cliente.CpfCliente.Formatar()}" +
                        $"\n{pedido4.Produto.Nome} {pedido4.QuantidadeVendida} unidades \nR${pedido4.CalculaValorTotal()}" +
                        $" - Imposto: R${pedido4.CalculaTotalImposto()}\nCEP: {pedido4.Cep} - Frete: R${pedido4.FretePedido}");
                    Console.WriteLine("---------------------------");

                    Console.WriteLine($"Notas Fiscais: \n{pedido1.Nota.GetNotaFiscal()}");
                    Console.WriteLine($"\n{pedido2.Nota.GetNotaFiscal()}");
                    Console.WriteLine($"\n{pedido3.Nota.GetNotaFiscal()}");
                    Console.WriteLine($"\n{pedido4.Nota.GetNotaFiscal()}");
                    Console.WriteLine("---------------------------");

                    Console.WriteLine($"Item: {itens1.Item}\n Quantidade: {itens1.Quantidade}\n Total: R${itens1.Total}");
                    Console.WriteLine($"Item: {itens2.Item}\n Quantidade: {itens2.Quantidade}\n Total: R${itens2.Total}");
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
