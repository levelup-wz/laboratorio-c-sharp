using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class EntradaInvalidaException : Exception
    {
        public EntradaInvalidaException(){}
        public EntradaInvalidaException(string mensagem) : base(mensagem){}
        public EntradaInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected EntradaInvalidaException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
