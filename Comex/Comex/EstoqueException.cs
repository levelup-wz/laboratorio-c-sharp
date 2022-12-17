using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class EstoqueException : Exception
    {
        public EstoqueException() 
        { 
        }

        public EstoqueException(string mensagem) : base(mensagem)
        {
        }

        public EstoqueException(string mensagem, Exception innerException) : base(mensagem, innerException) 
        { 
        }
    }
}
