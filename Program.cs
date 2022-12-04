using System;
using Comex.Categorias;
using Comex.Produtos;
using Comex.Pedidos;
using Comex.Clientes;

class Program
{
    static void Main()
    {
        // declaração das categorias
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria moveis = new Categoria("MÓVEIS", "INATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");

        // declaração dos produtos
        Produto notebookSamsung = new Produto("Notebook Samsung", "O melhor da marca!",
            3523.00, 1, "Informática");
        Produto cleanArchitecture = new Produto("Clean Architecture", "O melhor da marca!",
            102.90, 2, "Livros");
        Produto monitorDell = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00, 3, "Informática");

        // declaração do cliente
        Cliente danilo = new Cliente("Danilo", "Siervi", "12345678913", "32998145012", "Rua Legal",
            "D13", "Perto da prefeitura", "Centro", "Ouro Branco", "Minas Gerais");

        string op = "";

        while (op != "5")
        {
            Console.Clear();

            Console.WriteLine("Escolha a Categoria:");
            Console.WriteLine("{0} ({1} - {2}) \n{3} ({4} - {5}) \n{6} ({7} - {8}) \n4 - Conferir pedidos \n5 - Encerrar",
                informatica.Nome, informatica.Id, informatica.Status, moveis.Nome, moveis.Id,
                moveis.Status, livros.Nome, livros.Id, livros.Status);
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine("\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                        notebookSamsung.Categoria, notebookSamsung.Nome, notebookSamsung.Descricao,
                        notebookSamsung.Preco, notebookSamsung.Estoque, notebookSamsung.CalculaImposto());
                    Console.WriteLine("\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                        monitorDell.Categoria, monitorDell.Nome, monitorDell.Descricao,
                        monitorDell.Preco, monitorDell.Estoque, monitorDell.CalculaImposto());
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine("\nINATIVA");
                    Console.Read();
                    break;

                case "3":
                    Console.WriteLine("\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                        cleanArchitecture.Categoria, cleanArchitecture.Nome, cleanArchitecture.Descricao,
                        cleanArchitecture.Preco, cleanArchitecture.Estoque, cleanArchitecture.CalculaImposto());
                    Console.Read();
                    break;

                case "4":
                    Console.WriteLine();

                    break;
            }
        }
    }
}
