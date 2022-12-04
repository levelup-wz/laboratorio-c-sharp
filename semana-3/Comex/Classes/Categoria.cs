namespace Comex
{
  public class Categoria
  {
    public static int Id { get; set; }
    public string Nome { get; set; }
    public string Status { get; set; }

    public Categoria(string nome, string status = "ATIVA")
    {
      Id = Id + 1;
      Nome = nome;
      Status = status;
    }
  }
}