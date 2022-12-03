namespace Comex
{
  public class Categoria
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Status { get; set; } = "ATIVA";

    public Categoria(string nome)
    {
      Nome = nome;
    }
  }
}