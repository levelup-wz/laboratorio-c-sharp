namespace Comex
{
  public class Estoque
  {
    public int Capacidade { get; set; } = 1000;
    public int Ocupacao { get; set; }
    public decimal Montante { get; set; }

    public void RegistraEntrada(Produto produto)
    {
        Capacidade -= produto.QuantidadeEmEstoque;
        Ocupacao += produto.QuantidadeEmEstoque;
        Montante += Convert.ToDecimal(produto.CalculaValorTotalEmEstoque());
    }

    public void RegistraSaida(Produto produto)
    {
        Capacidade += produto.QuantidadeEmEstoque;
        Ocupacao -= produto.QuantidadeEmEstoque;
        Montante -= Convert.ToDecimal(produto.CalculaValorTotalEmEstoque());
    }
  }
}