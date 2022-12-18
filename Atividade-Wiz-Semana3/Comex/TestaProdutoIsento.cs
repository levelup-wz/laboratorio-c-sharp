using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public static class TestaProdutoIsento
    {
        static ProdutoIsento isento1 = new ProdutoIsento("Vacina", 250.00, 1000, "Saúde");
        static ProdutoIsento isento2 = new ProdutoIsento("Use a Cabeça: Java", 112.90, 5, "Livros");
        static ProdutoIsento isento3 = new ProdutoIsento("Macbook Pro", 20000.00, 11, "Informática");

        public static void MostraProdutoIsento()
        {
            Console.WriteLine($"Id do produto isento: {isento1.Id}");
            Console.WriteLine($"Nome: {isento1.Nome}");
            Console.WriteLine($"Preço unitário: {isento1.Preco_Unitario}");
            Console.WriteLine($"Quantidade em estoque: {isento1.Quantidade_Em_Estoque}");
            Console.WriteLine($"Categoria: {isento1.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento1.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento1.CalculaImposto().ToString("N2")}" + "\n");

            Console.WriteLine($"Id do produto isento: {isento2.Id}");
            Console.WriteLine($"Nome: {isento2.Nome}");
            Console.WriteLine($"Preço unitário: {isento2.Preco_Unitario}");
            Console.WriteLine($"Quantidade em estoque: {isento2.Quantidade_Em_Estoque}");
            Console.WriteLine($"Categoria: {isento2.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento2.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento2.CalculaImposto().ToString("N2")}" + "\n");

            Console.WriteLine($"Id do produto isento: {isento3.Id}");
            Console.WriteLine($"Nome: {isento3.Nome}");
            Console.WriteLine($"Preço unitário: {isento3.Preco_Unitario}");
            Console.WriteLine($"Quantidade em estoque: {isento3.Quantidade_Em_Estoque}");
            Console.WriteLine($"Categoria: {isento3.Categoria}");
            Console.WriteLine($"Valor total em estoque: {isento3.CalculaValorTotalEmEstoque().ToString("N2")}");
            Console.WriteLine($"Valor de Imposto: {isento3.CalculaImposto().ToString("N2")}" + "\n");
        }
    }
}
