using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaValidacaoDeProdutos
    {
        public static void Main()
        {
            Categoria teste = new Categoria("teste");
            Produto testeProduto = new Produto(0, "testeId", 2.00, 5, teste);
            Produto testeProduto1 = new Produto(1, "tesd", 2.00, 5, teste);
            Produto testeProduto2 = new Produto(1, "teste preço unitario", 0, 5, teste);
            Produto testeProduto3 = new Produto(1, "teste quantidade em estoque", 2, 0, teste);
            Produto testeProduto4 = new Produto(1, "testeDeSucesso", 2, 5, teste);
            Console.WriteLine("\n");
            ProdutoIsento testeProduto01 = new ProdutoIsento(0, "testeId", 2.00, 5, teste);
            ProdutoIsento testeProduto11 = new ProdutoIsento(1, "tesd", 2.00, 5, teste);
            ProdutoIsento testeProduto22 = new ProdutoIsento(1, "teste preço unitario", 0, 5, teste);
            ProdutoIsento testeProduto33 = new ProdutoIsento(1, "teste quantidade em estoque", 2, 0, teste);
            ProdutoIsento testeProduto44 = new ProdutoIsento(1, "teste Produto Isento De Sucesso", 2, 5, teste);
        }

    }
}
