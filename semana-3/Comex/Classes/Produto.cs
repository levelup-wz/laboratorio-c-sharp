namespace Comex
{
  public class Produto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public Categoria Categoria { get; set; }

    public Produto(int id, string nome, string descricao, double precoUnitario, int quantidadeEmEstoque, Categoria categoria)
    {
      Id = id;
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