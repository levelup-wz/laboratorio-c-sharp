/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex;

namespace Comex.Testes
{
    public class TestaValidacaoDeProdutos
    {
        try
        {
            Produto bala7Belo = new Produto(0, "Bala 7 Belo", 0.1, 5000, new Categoria("Alimentos"));
            ProdutoIsento useACabecaJava = new ProdutoIsento(2, "Use a cabeça: Java", 112.90, 5, new Categoria("Livros"));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"ERRO: {e.Message}");
            Console.WriteLine($"Método que lançou a exceção: {e.TargetSite}");
        }
    }
}*/