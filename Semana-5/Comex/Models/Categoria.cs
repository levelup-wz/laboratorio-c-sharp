using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(string nome, string status = "ATIVA")
        {
            Id = ++_id;
            Nome = nome;
            Status = status;
        }

        public string Informacoes()
        {
            return $"{Nome} ({Id} - {Status})";
        }
    }
}
