namespace Comex
{
  public class Produto
  {
    public static int Id { get; private set; }
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

      if(nome.Length <= 5)
      {
        throw new ArgumentException("O nome deve ser maior que 5 caracteres", nameof(nome));
      }

      if(precoUnitario <= 0)
      {
        throw new ArgumentException("O preço unitário deve ser maior que 0", nameof(precoUnitario));
      }

      if (quantidadeEmEstoque <= 0)
      {
        throw new ArgumentException("A quantidade em estoque deve ser maior que 0", nameof(quantidadeEmEstoque));
      }
    }

    public double CalculaValorTotalEmEstoque()
    {
      return PrecoUnitario * QuantidadeEmEstoque;
    }

    public virtual double CalcularImposto()
    {
      return PrecoUnitario * 0.4;
    }
  }
}