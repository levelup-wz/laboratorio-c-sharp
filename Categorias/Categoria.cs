using System;

namespace Comex.Categorias
{
    public class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string status { get; set; }

        public Categoria(int id, string nome, string status)
        {
            this.id = id;
            this.nome = nome;
            this.status = status;
        }
    }
}
