using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        private int _id;
        public int Id { get; set; }

        public string Nome { get; set; }
        public OpcoesStatus Status { get; set; }

        public Categoria(string nome, OpcoesStatus status = OpcoesStatus.ATIVA) 
        {
            Nome = nome;
            Status = status;
            Id = TotalCategorias + 1;
            TotalCategorias += 1;
        }

        public static int TotalCategorias { get; set; }
    }

    public enum OpcoesStatus
    {
        INATIVA = 0,
        ATIVA = 1
    }
}
