using System;

namespace Comex.Exceptions
{
    internal class LimiteDeEstoqueExcedidoException : Exception
    {
        public LimiteDeEstoqueExcedidoException() { }
        public LimiteDeEstoqueExcedidoException(string mensagem) : base(mensagem) { }
        public LimiteDeEstoqueExcedidoException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
    }
}
