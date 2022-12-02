using ProjetoOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO.Testes
{
    public class TesteCategoria
    {
        public static void Main(String[] args)
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            Categoria categoria = new Categoria();
            categoria.Id = 1;
            categoria.Nome = "INFORMÁTICA";
            categoria.Status = "ativa";
            listaCategorias.Add(categoria);

            categoria = new Categoria();
            categoria.Id = 2;
            categoria.Nome = "MÓVEIS";
            categoria.Status = "inativa";
            listaCategorias.Add(categoria);

            categoria = new Categoria();
            categoria.Id = 3;
            categoria.Nome = "LIVROS";
            categoria.Status = "ativa";
            listaCategorias.Add(categoria);

            foreach (var item in listaCategorias)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
