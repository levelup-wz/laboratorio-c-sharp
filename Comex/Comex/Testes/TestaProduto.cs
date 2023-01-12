/*using Comex.Categorias;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaProduto
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

        Console.WriteLine($"Produtos: \n\nCategoria: {notebook.Categoria.Nome} \nId: {notebook.Id} - {notebook.Nome}, {notebook.Descricao} " +
            $"R${notebook.Preco} \nQuantidade em estoque: {notebook.Estoque} \nImposto R${notebook.CalculaImposto()}");
        Console.WriteLine($"\nCategoria: {monitor.Categoria.Nome} \nId: {monitor.Id} - {monitor.Nome}, {monitor.Descricao} R${monitor.Preco}" +
            $"\nQuantidade em estoque: {monitor.Estoque} \nImposto R${monitor.CalculaImposto()}");
        Console.WriteLine($"Produtos: \n\nCategoria: {cleanA.Categoria.Nome} \nId: {cleanA.Id} - {cleanA.Nome}, {cleanA.Descricao} R${cleanA.Preco}" +
            $"\nQuantidade em estoque: {cleanA.Estoque} \nImposto R${cleanA.CalculaImposto()}");
    }
}
*/