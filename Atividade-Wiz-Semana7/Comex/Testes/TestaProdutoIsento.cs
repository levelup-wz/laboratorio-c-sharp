using Comex.Models;

namespace Comex.Testes
{
    public static class TestaProdutoIsento
    {
        static readonly ProdutoIsento isento1 = new("Vacina", 250.00, 1000, "Saúde", "");
        static readonly ProdutoIsento isento2 = new("Use a Cabeça: Java", 112.90, 5, "Livros", "");
        static readonly ProdutoIsento isento3 = new("Macbook Pro", 20000.00, 11, "Informática", "");

        public static void MostraProdutoIsento()
        {
            Console.WriteLine($"Id do produto isento: {isento1.Id}");
            Console.WriteLine($"Nome: {isento1.Nome}");
            Console.WriteLine($"Preço unitário: {isento1.PrecoUnitario}");
            Console.WriteLine($"Quantidade em estoque: {isento1.QuantidadeEmEstoque}");
            Console.WriteLine($"Categoria: {isento1.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento1.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento1.CalculaImposto().ToString("N2")}" + "\n");

            Console.WriteLine($"Id do produto isento: {isento2.Id}");
            Console.WriteLine($"Nome: {isento2.Nome}");
            Console.WriteLine($"Preço unitário: {isento2.PrecoUnitario}");
            Console.WriteLine($"Quantidade em estoque: {isento2.QuantidadeEmEstoque}");
            Console.WriteLine($"Categoria: {isento2.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento2.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento2.CalculaImposto().ToString("N2")}" + "\n");

            Console.WriteLine($"Id do produto isento: {isento3.Id}");
            Console.WriteLine($"Nome: {isento3.Nome}");
            Console.WriteLine($"Preço unitário: {isento3.PrecoUnitario}");
            Console.WriteLine($"Quantidade em estoque: {isento3.QuantidadeEmEstoque}");
            Console.WriteLine($"Categoria: {isento3.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento3.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento3.CalculaImposto().ToString("N2")}");
        }
    }
}
