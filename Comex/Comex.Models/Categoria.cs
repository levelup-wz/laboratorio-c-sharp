using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(string nome, string status = "ATIVA")
        {
            TotalCategorias += 1;

            Id = TotalCategorias;
            Nome = nome;
            Status = status;
        }

        public Categoria(int id, string nome, string status = "ATIVA")
        {
            if (id <= 0)
            {
                throw new ArgumentException("O valor do Id deve ser maior do que 0.");
            }

            if (nome.Length <= 3)
            {
                throw new ArgumentException("O nome deve possuir mais de 3 caracteres.");
            }

            if (String.Compare(status, "ATIVA") != 0 && String.Compare(status, "INATIVA") != 0) 
            {
                throw new ArgumentException("O status deve ser ATIVA ou INATIVA.");
            }

            Id = id;
            Nome = nome;
            Status = status;
        }

        public static int TotalCategorias { get; set; }
    }

    /*public enum OpcoesStatus
    {
        INATIVA = 0,
        ATIVA = 1
    }*/
}
