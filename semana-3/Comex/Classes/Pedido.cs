namespace Comex
{
  public class Pedido
  {
    public static int Id { get; set; }
    public DateTime Data { get; set; }
    public Cliente Cliente { get; set; }
    public Produto Produto { get; set; }
    public int QuantidadeVendida { get; set; }

    public Pedido(DateTime data, Cliente cliente, Produto produto, int quantidadeVendida)
    {
      Id = Id + 1;
      Data = data;
      Cliente = cliente;
      Produto = produto;
      QuantidadeVendida = quantidadeVendida;
    }

    public double CalcularValorTotal()
    {
      return Produto.PrecoUnitario * QuantidadeVendida;
    }

    public double CalcularValorTotalDeImpostos()
    {
      return Produto.CalcularImposto() * QuantidadeVendida;
    }
  }
}