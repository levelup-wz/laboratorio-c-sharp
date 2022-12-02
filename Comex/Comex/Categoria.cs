using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public OpcoesStatus Status { get; set; }

        public Categoria(string nome, OpcoesStatus status = OpcoesStatus.ATIVA) 
        {
            TotalCategorias += 1;

            Id = TotalCategorias;
            Nome = nome;
            Status = status;    
        }

        public static int TotalCategorias { get; set; }
    }

    public enum OpcoesStatus
    {
        INATIVA = 0,
        ATIVA = 1
    }
}
