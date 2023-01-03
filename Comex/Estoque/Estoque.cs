namespace Comex
{
  public class Estoque
  {
    public int Capacidade { get; set; } = 1000;
    public int Ocupacao { get; set; }
    public decimal Montante { get; set; }

    public void RegistraEntrada(Produto produto)
    {
        if(produto.QuantidadeEmEstoque > Capacidade)
            {
                throw new CapacityLimitExceededException("A quantidade de produto é maior que a capacidade do estoque.");
            }

        Capacidade -= produto.QuantidadeEmEstoque;
        Ocupacao += produto.QuantidadeEmEstoque;
        Montante += Convert.ToDecimal(produto.CalculaValorTotalEmEstoque());
    }

    public void RegistraSaida(Produto produto)
    {
        if(Ocupacao == 0)
            {
                throw new CapacityLimitExceededException("O estoque está vazio.");
            }

            Capacidade += produto.QuantidadeEmEstoque;
        Ocupacao -= produto.QuantidadeEmEstoque;
        Montante -= Convert.ToDecimal(produto.CalculaValorTotalEmEstoque());
    }
  }
}