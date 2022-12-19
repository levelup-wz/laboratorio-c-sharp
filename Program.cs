//using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Test;

namespace Comex
{
    class Program
    {
        public static void Main(string[] args)

        {
            TestCategory testeCategoria = new TestCategory();
            testeCategoria.ToList();

            TestProduct testeProduto = new TestProduct();
            testeProduto.ToList();

            TestOrder testePedido = new TestOrder();
            testePedido.ToList();

            TestProductExempt testeProdutoIsento = new TestProductExempt();
            testeProdutoIsento.ToList();

            TestCheckInStock testeEntradaProdutoEstoque = new TestCheckInStock();
            testeEntradaProdutoEstoque.ToList();

            TestCheckOutStock testeSaidaProdutoEstoque = new TestCheckOutStock();
            testeSaidaProdutoEstoque.ToList();





        }
    }
}
