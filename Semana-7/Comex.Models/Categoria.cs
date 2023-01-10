using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
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
            ValidaEntradaDeDados(nome, status);
        }

        public string Informacoes()
        {
            return $"{Nome} ({Id} - {Status})";
        }

        private void ValidaEntradaDeDados(string nome, string status)
        {
            if(nome.Length < 3)
            {
                throw new ArgumentException("O argumento nome deve ser maior que 0.", nameof(nome));
            }

            if (status.Equals("ATIVA") || status.Equals("INATIVA"))
            {
                Nome = nome;
                Status = status;
            }
            else
            {
                throw new ArgumentException("O argumento status deve ser ATIVA ou INATIVA", nameof(status));
            }
        }
    }
}
