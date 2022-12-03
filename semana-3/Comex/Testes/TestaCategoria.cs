namespace Comex.Testes
{
  public class TestaCategoria
  {
    public static void Main(string[] args)
    {
      Categoria categoriaUm = new Categoria();
      categoriaUm.Id = 1;
      categoriaUm.Nome = "INFORMÁTICA";

      Console.WriteLine($"{categoriaUm.Nome} ({categoriaUm.Id} - {categoriaUm.Status})");

      Categoria categoriaDois = new Categoria();
      categoriaDois.Id = 2;
      categoriaDois.Nome = "MÓVEIS";
      categoriaDois.Status = "INATIVA";

      Console.WriteLine($"{categoriaDois.Nome} ({categoriaDois.Id} - {categoriaDois.Status})");

      Categoria categoriaTres = new Categoria();
      categoriaTres.Id = 3;
      categoriaTres.Nome = "LIVROS";

      Console.WriteLine($"{categoriaTres.Nome} ({categoriaTres.Id} - {categoriaTres.Status})");

      Console.ReadKey();
    }
  }
}