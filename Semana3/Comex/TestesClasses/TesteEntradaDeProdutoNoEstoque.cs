using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TesteEntradaDeProdutoNoEstoque
    {
        public static void Main()
        {
            Categoria informatica = new Categoria("informática");
            Categoria saude = new Categoria("saúde");
            Categoria livros = new Categoria("livros");
            Categoria alimentos = new Categoria("Alimentos");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 980, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça", 112.90, 5, livros);
            Produto macbook = new Produto("Macbook Pro", 20000.00, 15, informatica);
            Produto bala7belo = new Produto("Bala 7 Belo", 0.1, 5000, alimentos);


            Console.WriteLine("*************** Testar Entrada de Produto no Estoque ***********");

            Estoque estoque = new Estoque();
            estoque.RegistrarEntrada(vacina);
            estoque.RegistrarEntrada(useACabeca);
            estoque.RegistrarEntrada(macbook);
            estoque.RegistrarEntrada(bala7belo);

            estoque.ListarEstoque();

        }

    }
}
