using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaPedido
    {
        Pedido Pedido1 = new Pedido(1, "99999999999", new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática"), 10);
        Pedido Pedido2 = new Pedido(2, "99999999999", new Produto(2, "Clean Architecture", 102.90, 2, "Livros"), 5);
        Pedido Pedido3 = new Pedido(3, "99999999999", new Produto(3, "Monitor Dell 27", 1889.00, 3, "Informática"), 2);

        public TestaPedido()
        {
            Console.WriteLine($" Nome: {Pedido1.Produto.Nome}\n Categoria: {Pedido1.Produto.Categoria}\n Valor total:{Pedido1.ValorTotal():C2}\n Impostos:{Pedido1.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome: {Pedido2.Produto.Nome}\n Categoria: {Pedido2.Produto.Categoria}\n Valor total:{Pedido2.ValorTotal():C2}\n Impostos:{Pedido2.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome: {Pedido3.Produto.Nome}\n Categoria: {Pedido3.Produto.Categoria}\n Valor total:{Pedido3.ValorTotal():C2}\n Impostos:{Pedido3.TotalDeImpostos():C2}\n");
        }
    }
}
