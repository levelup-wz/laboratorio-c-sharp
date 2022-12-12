using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class LimiteDeEstoqueExcedidoException : Exception
    {
        public LimiteDeEstoqueExcedidoException(string mensagem) : base(mensagem)
        {
            
        }
    }
}
