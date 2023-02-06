namespace Comex
{
  public class Categoria
  {
    public static int Id { get; private set; }
    public string Nome { get; set; }
    public string Status { get; set; }

    public Categoria(string nome, string status = "ATIVA")
    {
      Id++;
      Nome = nome;
      Status = status;

      if (nome.Length <= 3)
      {
        throw new ArgumentException("O nome deve ser maior que 3 caracteres", nameof(nome));
      }
      if (status != "ATIVA" && status != "INATIVA")
      {
        throw new ArgumentException("Só é permitido os valores 'ATIVA' e 'INATIVA'", nameof(status));
      }
    }
  }
}