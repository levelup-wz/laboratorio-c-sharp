/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;

namespace Comex.Testes
{
    public class TestaProdutoIsento
    {
        static void Main(string[] args)
        {
            Categoria saude = new Categoria("Saúde");
            Categoria livros = new Categoria("Livros");
            Categoria informatica = new Categoria("Informática");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 1000, saude);
            ProdutoIsento useACabecaJava = new ProdutoIsento("Use a cabeça: Java", 112.90, 5, livros);
            Produto macbookPro = new Produto("Macbook Pro", 20000.00, 11, informatica);

            Console.WriteLine(
                $"Id: {vacina.Id}\n" +
                $"Nome: {vacina.Nome}\n" +
                $"Categoria: {vacina.ProdutoCategoria.Nome}\n" +
                $"Preço unitário: {vacina.PrecoUnitario:C}\n" +
                $"Imposto por unidade: {vacina.CalcularImposto():C}\n" +
                $"Quantidade em estoque: {vacina.QuantidadeEmEstoque}\n"
            );

            Console.WriteLine(
                $"Id: {useACabecaJava.Id}\n" +
                $"Nome: {useACabecaJava.Nome}\n" +
                $"Categoria: {useACabecaJava.ProdutoCategoria.Nome}\n" +
                $"Preço unitário: {useACabecaJava.PrecoUnitario:C}\n" +
                $"Imposto por unidade: {useACabecaJava.CalcularImposto():C}\n" +
                $"Quantidade em estoque: {useACabecaJava.QuantidadeEmEstoque}\n"
            );

            Console.WriteLine(
                $"Id: {macbookPro.Id}\n" +
                $"Nome: {macbookPro.Nome}\n" +
                $"Categoria: {macbookPro.ProdutoCategoria.Nome}\n" +
                $"Preço unitário: {macbookPro.PrecoUnitario:C}\n" +
                $"Imposto por unidade: {macbookPro.CalcularImposto():C}\n" +
                $"Quantidade em estoque: {macbookPro.QuantidadeEmEstoque}\n"
            );
        }
    }
}
*/