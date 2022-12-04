namespace Comex
{
  public class Categoria
  {
    public static int Id { get; set; }
    public string Nome { get; set; }
    public string Status { get; set; } = "ATIVA";

    public Categoria(string nome)
    {
      Id = Id + 1;
      Nome = nome;
    }
  }
}