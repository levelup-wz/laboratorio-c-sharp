using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class SaidaInvalidaException : Exception
    {
        public SaidaInvalidaException() { }
        public SaidaInvalidaException(string mensagem) : base(mensagem) { }
        public SaidaInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected SaidaInvalidaException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
