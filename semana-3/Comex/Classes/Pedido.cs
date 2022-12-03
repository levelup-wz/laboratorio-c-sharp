namespace Comex
{
  public class Pedido
  {
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Cliente { get; set; }
    public Produto Produto { get; set; }
    public int QuantidadeVendida { get; set; }

    public Pedido(int id, DateTime data, string cliente, Produto produto, int quantidadeVendida)
    {
      Id = id;
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