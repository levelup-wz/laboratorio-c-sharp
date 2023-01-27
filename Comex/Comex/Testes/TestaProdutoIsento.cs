using Comex.Modelos.Categorias;
using Comex.Modelos.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaProdutoIsento
    {
        static Categoria informatica = new("INFORMÁTICA", "ATIVA");
        static Categoria livros = new("LIVROS", "ATIVA");
        static Categoria saude = new("SAUDE", "ATIVA");

        static ProdutoIsento vacina = new("Vacina", "Vacinas para todas as doenças",
            (decimal)250.00, 500, saude);
        static ProdutoIsento livroJava = new("Use a Cabeça: Java", "Descomplicando Java",
            (decimal)112.90, 5, livros);
        static ProdutoIsento macbookPro = new("Macbook pro", "O melhor da marca!",
            (decimal)20000.00, 15, informatica);

        public static void ExecutarTeste()
        {
            Console.Clear();
            Console.WriteLine("Testa Produto Isento\n");
            Console.WriteLine($"{vacina} \n\n{livroJava} \n\n{macbookPro}");
            Console.ReadKey();
        }
    }
}
