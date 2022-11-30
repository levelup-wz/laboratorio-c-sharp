using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaProduto
    {
        public TestaProduto() 
        {
            Produto produto1 = new Produto();
            produto1.Id = 1;
            produto1.Nome = "Notebook Samsung";
            produto1.Preco_Unitario = 3523.00;
            produto1.Quantidade_Em_Estoque = 1;
            produto1.Categoria = "Informática";

            Produto produto2 = new Produto();
            produto2.Id = 2;
            produto2.Nome = "Clean Architecture";
            produto2.Preco_Unitario = 102.90;
            produto2.Quantidade_Em_Estoque = 2;
            produto2.Categoria = "Livros";

            Produto produto3 = new Produto();
            produto3.Id = 3;
            produto3.Nome = "Monitor Dell 27";
            produto3.Preco_Unitario = 1889.00;
            produto3.Quantidade_Em_Estoque = 3;
            produto3.Categoria = "Informática";

            Console.WriteLine(produto1.Categoria + " (" + produto1.Id + " - " + produto1.Nome + ") " + "\n" +
                                "Quantidade em estoque: " + produto1.Quantidade_Em_Estoque + "\n" + 
                                produto1.CalculaValorTotalEmEstoque() + "\n" +
                                "Preço unitário: " + produto1.Preco_Unitario + "\n" +
                                produto1.CalculaImposto() + "\n");

            Console.WriteLine(produto2.Categoria + " (" + produto2.Id + " - " + produto2.Nome + ") " + "\n" +
                                "Quantidade em estoque: " + produto2.Quantidade_Em_Estoque + "\n" +
                                produto2.CalculaValorTotalEmEstoque() + "\n" +
                                "Preço unitário: " + produto2.Preco_Unitario + "\n" +
                                produto2.CalculaImposto() + "\n");

            Console.WriteLine(produto3.Categoria + " (" + produto3.Id + " - " + produto3.Nome + ") " + "\n" +
                                "Quantidade em estoque: " + produto3.Quantidade_Em_Estoque + "\n" +
                                produto3.CalculaValorTotalEmEstoque() + "\n" +
                                "Preço unitário: " + produto3.Preco_Unitario + "\n" +
                                produto3.CalculaImposto() + "\n");
        }
    }
}
