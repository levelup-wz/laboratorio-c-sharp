namespace Comex
{
  public class Produto
  {
    public static int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public Categoria Categoria { get; set; }

    public Produto(string nome, string descricao, double precoUnitario, int quantidadeEmEstoque, Categoria categoria)
    {
      Id = Id + 1;
      Nome = nome;
      Descricao = descricao;
      PrecoUnitario = precoUnitario;
      QuantidadeEmEstoque = quantidadeEmEstoque;
      Categoria = categoria;
    }

    public double CalculaValorTotalEmEstoque()
    {
      return PrecoUnitario * QuantidadeEmEstoque;
    }

    public double CalcularImposto()
    {
      return PrecoUnitario * 0.4;
    }
  }
}