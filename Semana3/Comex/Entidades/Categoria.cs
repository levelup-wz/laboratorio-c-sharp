using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Categoria
    {
        private static int numId = 1;
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public EStatus Status { get; private set; }

        public Categoria(string nome, EStatus status = EStatus.Ativa)
        {
            Status = status;
            Nome = nome.ToUpper();
            Id = Categoria.numId;
            Categoria.numId++;
        }
        public void ListarCategoria()
        {
            Console.WriteLine($"{Nome} ({Id} - {Status})");
        }
                
    }
}
