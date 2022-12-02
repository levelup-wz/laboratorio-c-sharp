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

        public Categoria(OpcoesStatus status = OpcoesStatus.ATIVA) 
        {
            Status = status;
        }
    }

    public enum OpcoesStatus
    {
        INATIVA = 0,
        ATIVA = 1
    }
}
