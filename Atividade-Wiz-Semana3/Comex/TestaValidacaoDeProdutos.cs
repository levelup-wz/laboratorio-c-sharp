using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaValidacaoDeProdutos
    {
        public static void RegistaEntradaProdutos()
        {
            try
            {
                Produto teste1 = new Produto(0, "Notebook Samsung", 3523.00, 1, "Informática");

                Console.WriteLine($"{teste1.Categoria} ({teste1.DefineId()} - {teste1.Nome})");
                Console.WriteLine($"Quantidade em estoque: {teste1.Quantidade_Em_Estoque}");
                Console.WriteLine($"Valor total em estoque: {teste1.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Preço unitário: {teste1.Preco_Unitario}");
                Console.WriteLine($"Valor de Imposto: {teste1.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Produto teste2 = new Produto(31, "Clean", 102.90, 2, "Livros");

                Console.WriteLine($"{teste2.Categoria} ({teste2.DefineId()} - {teste2.Nome})");
                Console.WriteLine($"Quantidade em estoque: {teste2.Quantidade_Em_Estoque}");
                Console.WriteLine($"Valor total em estoque: {teste2.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Preço unitário: {teste2.Preco_Unitario}");
                Console.WriteLine($"Valor de Imposto: {teste2.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Produto teste3 = new Produto(32, "Monitor Dell 27", 0, 3, "Informática");

                Console.WriteLine($"{teste3.Categoria} ({teste3.DefineId()} - {teste3.Nome})");
                Console.WriteLine($"Quantidade em estoque: {teste3.Quantidade_Em_Estoque}");
                Console.WriteLine($"Valor total em estoque: {teste3.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Preço unitário: {teste3.Preco_Unitario}");
                Console.WriteLine($"Valor de Imposto: {teste3.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Produto teste4 = new Produto(33, "Código Limpo", 102.90, 0, "Livros");

                Console.WriteLine($"{teste4.Categoria} ({teste4.DefineId()} - {teste4.Nome})");
                Console.WriteLine($"Quantidade em estoque: {teste4.Quantidade_Em_Estoque}");
                Console.WriteLine($"Valor total em estoque: {teste4.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Preço unitário: {teste4.Preco_Unitario}");
                Console.WriteLine($"Valor de Imposto: {teste4.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                Produto teste5 = new Produto(34, "mouse pad", 50.00, 3, "");

                Console.WriteLine($"{teste5.Categoria} ({teste5.DefineId()} - {teste5.Nome})");
                Console.WriteLine($"Quantidade em estoque: {teste5.Quantidade_Em_Estoque}");
                Console.WriteLine($"Valor total em estoque: {teste5.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Preço unitário: {teste5.Preco_Unitario}");
                Console.WriteLine($"Valor de Imposto: {teste5.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
        }

        public static void RegistaEntradaProdutosIsentos()
        {
            try
            {
                ProdutoIsento teste1 = new ProdutoIsento(0, "Vacina", 250.00, 1000, "Saúde");

                Console.WriteLine($"Id do produto isento: {teste1.Id}");
                Console.WriteLine($"Nome: {teste1.Nome}");
                Console.WriteLine($"Preço unitário: {teste1.Preco_Unitario}");
                Console.WriteLine($"Quantidade em estoque: {teste1.Quantidade_Em_Estoque}");
                Console.WriteLine($"Categoria: {teste1.Categoria}");
                Console.WriteLine($"Valor total em estoque: {teste1.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Valor de Imposto: {teste1.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                ProdutoIsento teste2 = new ProdutoIsento(41, "Java", 112.90, 5, "Livros");

                Console.WriteLine($"Id do produto isento: {teste2.Id}");
                Console.WriteLine($"Nome: {teste2.Nome}");
                Console.WriteLine($"Preço unitário: {teste2.Preco_Unitario}");
                Console.WriteLine($"Quantidade em estoque: {teste2.Quantidade_Em_Estoque}");
                Console.WriteLine($"Categoria: {teste2.Categoria}");
                Console.WriteLine($"Valor total em estoque: {teste2.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Valor de Imposto: {teste2.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                ProdutoIsento teste3 = new ProdutoIsento(42, "Macbook Pro", 0, 11, "Informática");

                Console.WriteLine($"Id do produto isento: {teste3.Id}");
                Console.WriteLine($"Nome: {teste3.Nome}");
                Console.WriteLine($"Preço unitário: {teste3.Preco_Unitario}");
                Console.WriteLine($"Quantidade em estoque: {teste3.Quantidade_Em_Estoque}");
                Console.WriteLine($"Categoria: {teste3.Categoria}");
                Console.WriteLine($"Valor total em estoque: {teste3.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Valor de Imposto: {teste3.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                ProdutoIsento teste4 = new ProdutoIsento(43, "Luvas Descartáveis", 250.00, 0, "Saúde");

                Console.WriteLine($"Id do produto isento: {teste4.Id}");
                Console.WriteLine($"Nome: {teste4.Nome}");
                Console.WriteLine($"Preço unitário: {teste4.Preco_Unitario}");
                Console.WriteLine($"Quantidade em estoque: {teste4.Quantidade_Em_Estoque}");
                Console.WriteLine($"Categoria: {teste4.Categoria}");
                Console.WriteLine($"Valor total em estoque: {teste4.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Valor de Imposto: {teste4.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
            try
            {
                ProdutoIsento teste5 = new ProdutoIsento(44, "Algoritmos e Lógica da Programação", 112.90, 5, "");

                Console.WriteLine($"Id do produto isento: {teste5.Id}");
                Console.WriteLine($"Nome: {teste5.Nome}");
                Console.WriteLine($"Preço unitário: {teste5.Preco_Unitario}");
                Console.WriteLine($"Quantidade em estoque: {teste5.Quantidade_Em_Estoque}");
                Console.WriteLine($"Categoria: {teste5.Categoria}");
                Console.WriteLine($"Valor total em estoque: {teste5.CalculaValorTotalEmEstoque().ToString("N2")}");
                Console.WriteLine($"Valor de Imposto: {teste5.CalculaImposto().ToString("N2")}" + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"{ex.Message} \n");
            }
        }
    }
}
