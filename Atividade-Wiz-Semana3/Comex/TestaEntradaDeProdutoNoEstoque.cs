using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutoNoEstoque
    {
        public void RegistraEntradaEstoque()
        {
            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, "Saúde");
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabeça: Java", 112.90, 5, "Livros");
            Produto macbook = new Produto("Macbook Pro", 20000.00, 15, "Informática");

            Estoque estoque = new Estoque();

            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(useACabeca);
            estoque.RegistraEntrada(macbook);
        }
    }
}
