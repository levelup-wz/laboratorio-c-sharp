using Comex.Modelos.Categorias;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaItensDoPedido
    {
        static Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");

        static Produto notebook = new Produto("Notebook Samsung", "O melhor da marca!",
            3523.00M, 1, informatica);
        static Produto monitor = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00M, 3, informatica);

        static ItensDoPedido itens1 = new ItensDoPedido(notebook, 3);
        static ItensDoPedido itens2 = new ItensDoPedido(monitor, 4);

        public static void ExecutarTeste()
        {
            Console.Clear();
            Console.WriteLine("Testa Itens do Pedido");
            Console.WriteLine($"{itens1} \n\n{itens2}");
            Console.ReadKey();
        }
    }
}
