/*using Comex.Categorias;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaProdutoIsento
    {
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");
        Categoria saude = new Categoria("SAUDE", "ATIVA");

        Produto vacina = new ProdutoIsento("Vacina", "Vacinas para todas as doenças",
            250.00, 500, saude);
        Produto livroJava = new ProdutoIsento("Use a Cabeça: Java", "Descomplicando Java",
            112.90, 5, livros);
        Produto macbookPro = new ProdutoIsento("Macbook pro", "O melhor da marca!",
            20000.00, 15, informatica);

        Console.WriteLine($"Produtos: \n\nCategoria: {vacina.Categoria.Nome} \nId: {vacina.Id} - {vacina.Nome}, {vacina.Descricao} R${vacina.Preco}" +
            $"\nQuantidade em estoque: {vacina.Estoque} \nImposto R${vacina.CalculaImposto()}");
        Console.WriteLine($"\nCategoria: {livroJava.Categoria.Nome} \nId: {livroJava.Id} - {livroJava.Nome}, {livroJava.Descricao} " +
            $"R${livroJava.Preco} \nQuantidade em estoque: {livroJava.Estoque} \nImposto R${livroJava.CalculaImposto()}");
        Console.WriteLine($"\nCategoria: {macbookPro.Categoria.Nome} \nId: {macbookPro.Id} - {macbookPro.Nome}, {macbookPro.Descricao} " +
            $"R${macbookPro.Preco} \nQuantidade em estoque: {macbookPro.Estoque} \nImposto R${macbookPro.CalculaImposto()}");
    }
}
*/
