using System;

namespace Comex.Categorias
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(int id, string nome, string status)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }
}
