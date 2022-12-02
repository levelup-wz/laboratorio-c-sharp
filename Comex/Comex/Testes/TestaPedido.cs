/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Testes
{
    public class TestaPedido
    {
        Categoria categoria1 = new Categoria("Informática");
        Categoria categoria2 = new Categoria("Livros");

        Produto produto1 = new Produto("Notebook Samsung", 3523.00, 1);
        produto1.ProdutoCategoria = categoria1;

        Produto produto2 = new Produto("Clean Architecture", 102.90, 2);
        produto2.ProdutoCategoria = categoria2;

        Produto produto3 = new Produto("Monitor Dell 27", 1889.00, 3);
        produto3.ProdutoCategoria = categoria1;

        Pedido pedido1 = new Pedido("012.345.678-90", produto1, 1);
        Pedido pedido2 = new Pedido("098.765.432-10", produto2, 1);
        Pedido pedido3 = new Pedido("234.567.890-12", produto3, 1);

        Console.WriteLine(
            $"Id do pedido: {pedido1.Id}\n" +
            $"Data: {String.Format("{0:dd/MM/yyyy}", pedido1.Data)}\n" +
            $"Categoria: {pedido1.PedidoProduto.ProdutoCategoria.Nome}\n" +
            $"Nome do produto: {pedido1.PedidoProduto.Nome}\n" +
            $"Total de Impostos: R$ {Math.Round(pedido1.CalcularImposto(), 2)}\n" +
            $"Valor Total: R$ {pedido1.CalcularValorTotal()}\n"
        );

        Console.WriteLine(
            $"Id do pedido: {pedido2.Id}\n" +
            $"Data: {String.Format("{0:dd/MM/yyyy}", pedido2.Data)}\n" +
            $"Categoria: {pedido2.PedidoProduto.ProdutoCategoria.Nome}\n" +
            $"Nome do produto: {pedido2.PedidoProduto.Nome}\n" +
            $"Total de Impostos: R$ {Math.Round(pedido2.CalcularImposto(), 2)}\n" +
            $"Valor Total: R$ {pedido2.CalcularValorTotal()}\n"
        );

        Console.WriteLine(
            $"Id do pedido: {pedido3.Id}\n" +
            $"Data: {String.Format("{0:dd/MM/yyyy}", pedido3.Data)}\n" +
            $"Categoria: {pedido3.PedidoProduto.ProdutoCategoria.Nome}\n" +
            $"Nome do produto: {pedido3.PedidoProduto.Nome}\n" +
            $"Total de Impostos: R$ {Math.Round(pedido3.CalcularImposto(), 2)}\n" +
            $"Valor Total: R$ {pedido3.CalcularValorTotal()}\n"
        );
    }
}
*/