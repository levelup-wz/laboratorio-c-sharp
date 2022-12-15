namespace Comex.Testes
{
  public class TestaCategoria
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
      
      Estoque estoqueDois = new Estoque();
      Categoria categoriaLivros = new Categoria("Livros");
      ProdutoIsento produtoDois = new ProdutoIsento("Use a Cabeça: Java", "Programação", 112.90, 5, categoriaLivros);
      estoqueDois.RegistraEntrada(produtoDois);
      Console.WriteLine($"Capacidade: {estoqueDois.Capacidade}\n" +
      $"Ocupação: {estoqueDois.Ocupacao}\n" +
      $"Montante: {estoqueDois.Montante}\n"
      );

      Estoque estoqueTres = new Estoque();
      Categoria categoriaInformatica = new Categoria("Informática");
      Produto produtoTres = new Produto("Macbook Pro", "Última geração", 20000.00, 15, categoriaInformatica);
      estoqueTres.RegistraEntrada(produtoTres);
      Console.WriteLine($"Capacidade: {estoqueTres.Capacidade}\n" +
      $"Ocupação: {estoqueTres.Ocupacao}\n" +
      $"Montante: {estoqueTres.Montante}\n"
      );
    }
  }
}