using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class LimiteDeEstoqueExcedidoException : Exception
    {
        public LimiteDeEstoqueExcedidoException(){}
        public LimiteDeEstoqueExcedidoException(string mensagem) : base(mensagem){}
        public LimiteDeEstoqueExcedidoException(string message, Exception inner) : base(message, inner) { }
        protected LimiteDeEstoqueExcedidoException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
