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
        public void Main()
        {
            Categoria informatica = new Categoria("informática");
            Categoria saude = new Categoria("saúde");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça", 112.90, 5, livros);
            Produto macbook = new Produto("Macbook Pro", 20000.00, 15, informatica);

            Estoque estoque = new Estoque();
            estoque.RegistrarEntrada(vacina);
            estoque.RegistrarEntrada(useACabeca);
            estoque.RegistrarEntrada(macbook);

            estoque.ListarEstoque();

        }

    }
}
