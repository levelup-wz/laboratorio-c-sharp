namespace Comex.Testes
{
  public class TestaProdutoIsento
  {
    public static void Main(string[] args)
    {
      Categoria categoriaSaude = new Categoria("Saúde");
      ProdutoIsento produtoUm = new ProdutoIsento("Vacina", "Vacina ...", 250.00, 1000, categoriaSaude);

      Console.WriteLine($"Id: {Produto.Id} \n " +
                        $"Produto: {produtoUm.Nome} \n " +
                        $"Descrição: {produtoUm.Descricao} \n " +
                        $"Preço unitário: {produtoUm.PrecoUnitario} \n " +
                        $"Quantidade: {produtoUm.QuantidadeEmEstoque} \n " +
                        $"Categoria: {produtoUm.Categoria.Nome} \n " +
                        $"Valor total em estoque: R${produtoUm.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
                        $"Imposto: R${produtoUm.CalcularImposto().ToString("F2")}");

      Categoria categoriaLivros = new Categoria("Livros");
      ProdutoIsento produtoDois = new ProdutoIsento("Use a Cabeça: Java", "Programação", 112.90, 5, categoriaLivros);

      Console.WriteLine($"Id: {Produto.Id} \n " +
                        $"Produto: {produtoDois.Nome} \n " +
                        $"Descrição: {produtoDois.Descricao} \n " +
                        $"Preço unitário: {produtoDois.PrecoUnitario} \n " +
                        $"Quantidade: {produtoDois.QuantidadeEmEstoque} \n " +
                        $"Categoria: {produtoDois.Categoria.Nome} \n " +
                        $"Valor total em estoque: R${produtoDois.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
                        $"Imposto: R${produtoDois.CalcularImposto().ToString("F2")}");
    
      Categoria categoriaInformatica = new Categoria("Informática");
      Produto produtoTres = new Produto("Macbook Pro", "Última geração", 20000.00, 11, categoriaInformatica);

      Console.WriteLine($"Id: {Produto.Id} \n " +
                        $"Produto: {produtoTres.Nome} \n " +
                        $"Descrição: {produtoTres.Descricao} \n " +
                        $"Preço unitário: {produtoTres.PrecoUnitario} \n " +
                        $"Quantidade: {produtoTres.QuantidadeEmEstoque} \n " +
                        $"Categoria: {produtoTres.Categoria.Nome} \n " +
                        $"Valor total em estoque: R${produtoTres.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
                        $"Imposto: R${produtoTres.CalcularImposto().ToString("F2")}");

      Console.ReadKey();
    }
  }
}