namespace Comex.Testes
{
  public class TestaSaidaDeProdutoNoEstoque
  {
    public static void Main(string[] args)
    {
      Estoque estoqueUm = new Estoque();
      Categoria categoriaSaude = new Categoria("Saúde");
      ProdutoIsento produtoUm = new ProdutoIsento("Vacina", "Vacina ...", 250.00, 500, categoriaSaude);

      estoqueUm.RegistraEntrada(produtoUm);

      Console.WriteLine($"Capacidade: {estoqueUm.Capacidade}\n" +
      $"Ocupação: {estoqueUm.Ocupacao}\n" +
      $"Montante: {estoqueUm.Montante}\n"
      );

      estoqueUm.RegistraSaida(produtoUm);

      Console.WriteLine($"Capacidade: {estoqueUm.Capacidade}\n" +
      $"Ocupação: {estoqueUm.Ocupacao}\n" +
      $"Montante: {estoqueUm.Montante}\n"
      );
    }
  }
}