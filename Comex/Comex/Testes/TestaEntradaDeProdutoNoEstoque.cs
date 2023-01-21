/*using Comex.Categorias;
using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");
        Categoria saude = new Categoria("SAUDE", "ATIVA");

        Produto vacina = new ProdutoIsento("Vacina", "Vacinas para todas as doenças",
            (decimal)250.00, 500, saude);
        Produto livroJava = new ProdutoIsento("Use a Cabeça: Java", "Descomplicando Java",
            (decimal)112.90, 5, livros);
        Produto macbookPro = new ProdutoIsento("Macbook pro", "O melhor da marca!",
            (decimal)20000.00, 15, informatica);

        Estoque estoque = new Estoque();
        estoque.RegistraEntrada(vacina);
        estoque.RegistraEntrada(livroJava);
        estoque.RegistraEntrada(macbookPro);

        Console.WriteLine($"Capacidade: {estoque.Capacidade} \nOcupação: {estoque.Ocupacao} \nMontante: {estoque.Montante}");

        Categoria alimentos = new Categoria("ALIMENTOS", "ATIVA");
        Produto bala = new Produto("Bala 7 Belo", "A mais gostosa",
            (decimal)0.1, 5000, alimentos);

        try
        {
            estoque.RegistraEntrada(bala);
        }
        catch(LimiteDeEstoqueExcedidoException ex)
        {
            Console.WriteLine($"Erro do tipo: {ex.Message}");
        }
    }
}
*/