namespace Comex
{
  class LimiteDeEstoqueExcedidoException : Exception
  {
    public LimiteDeEstoqueExcedidoException(string message) : base(message)
    {
    }
  }
}