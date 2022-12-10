
using Comex;
using System;

namespace Comex
{

    public class ProdutoTeste
    {
        ProdutoNaoIsento produto1 = new ProdutoNaoIsento("Notebook Samsung", 3523, 1, "Informática");
        ProdutoNaoIsento produto2 = new ProdutoNaoIsento("Clean Architecture", 102.90, 2, "Livros");
        ProdutoNaoIsento produto3 = new ProdutoNaoIsento("Monitor Dell 27", 1889, 3, "Informática");


        public ProdutoTeste()
        {
            Console.WriteLine(produto1.RetornaInfosProduto());
            Console.WriteLine(produto2.RetornaInfosProduto());
            Console.WriteLine(produto3.RetornaInfosProduto());
        }


    }
}

