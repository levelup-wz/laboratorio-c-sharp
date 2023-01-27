using Comex.Modelos.Categorias;
using Comex.Modelos.Clientes;
using Comex.Modelos.Pedidos;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaPedido
    {
        static Categoria informatica = new("INFORMÁTICA", "ATIVA");
        static Categoria moveis = new("MÓVEIS", "INATIVA");
        static Categoria livros = new("LIVROS", "ATIVA");

        static Produto notebook = new("Notebook Samsung", "O melhor da marca!",
            3523.00M, 1, informatica);
        static Produto cleanA = new("Clean Architecture", "O melhor da marca!",
            102.90M, 2, livros);
        static Produto monitor = new("Monitor Dell", "O melhor da marca!",
            1889.00M, 3, informatica);

        static Cliente danilo = new("Danilo", "Siervi", new Cpf("12345678913"), "999999999", "Rua Legal",
            "D13", "Perto de casa", "Centro", "Cidade bonita", "Minas Gerais");

        static ItensDoPedido itens1 = new(notebook, 3);
        static ItensDoPedido itens2 = new(monitor, 4);
        // static ItensDoPedido itens3 = new(vacina, 100);
        // static ItensDoPedido itens4 = new(vestido, 4);
        // static ItensDoPedido itens5 = new(bala, 10);
        // static ItensDoPedido itens6 = new(livroJava, 2);

        static Pedido pedido1 = new("02/12/2022", danilo, "08532-220", itens1, itens2);
        //static Pedido pedido2 = new"03/12/2022", danilo, "83992-332", itens3, itens5, itens6);
        static Pedido pedido3 = new("03/12/2022", danilo, "36623-293", itens1);

        public static void ExecutarTeste()
        {
            Console.Clear();
            Console.WriteLine("Testa Pedido\n");
            Console.WriteLine($"{pedido1} \n\n{pedido3}");

            //Console.WriteLine($"Notas Fiscais: \n{pedido1.Nota.GetNotaFiscal()}");
            //Console.WriteLine($"\n{pedido2.Nota.GetNotaFiscal()}");
            //Console.WriteLine($"\n{pedido3.Nota.GetNotaFiscal()}");
            //Console.WriteLine($"\n{pedido4.Nota.GetNotaFiscal()}");
            Console.ReadKey();
        }
    }
}
