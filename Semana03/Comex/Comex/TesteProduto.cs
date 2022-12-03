
using Comex;
using System;

namespace Comex
{

    public class ProdutoTeste
    {
        Produto produto1 = new Produto("Notebook Samsung", 3523, 1, "Informática");
        Produto produto2 = new Produto("Clean Architecture", 102.90, 2, "Livros");
        Produto produto3 = new Produto("Monitor Dell 27", 1889, 3, "Informática");


        public ProdutoTeste()
        {
            Console.WriteLine(produto1.RetornaInfosProduto());
            Console.WriteLine(produto2.RetornaInfosProduto());
            Console.WriteLine(produto3.RetornaInfosProduto());
        }


    }
}

