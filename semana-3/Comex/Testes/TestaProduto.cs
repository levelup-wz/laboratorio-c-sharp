// namespace Comex.Testes
// {
//   public class TestaProduto
//   {
//     public static void Main(string[] args)
//     {
//       Categoria categoriaInformatica = new Categoria("Informática");
//       Produto produtoUm = new Produto("Notebook Samsung", "Notebook Samsung 8GB", 3523.00, 1, categoriaInformatica);

//       Console.WriteLine($"Id: {Produto.Id} \n " +
//                         $"Produto: {produtoUm.Nome} \n " +
//                         $"Descrição: {produtoUm.Descricao} \n " +
//                         $"Preço unitário: {produtoUm.PrecoUnitario} \n " +
//                         $"Quantidade: {produtoUm.QuantidadeEmEstoque} \n " +
//                         $"Categoria: {produtoUm.Categoria.Nome} \n " +
//                         $"Valor total em estoque: R${produtoUm.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
//                         $"Imposto: R${produtoUm.CalcularImposto().ToString("F2")}");

//       Categoria categoriaLivros = new Categoria("Livros");
//       Produto produtoDois = new Produto("Clean Architecture", "Clean Architecture", 102.90, 2, categoriaLivros);

//       Console.WriteLine($"Id: {Produto.Id} \n " +
//                         $"Produto: {produtoDois.Nome} \n " +
//                         $"Descrição: {produtoDois.Descricao} \n " +
//                         $"Preço unitário: {produtoDois.PrecoUnitario} \n " +
//                         $"Quantidade: {produtoDois.QuantidadeEmEstoque} \n " +
//                         $"Categoria: {produtoDois.Categoria.Nome} \n " +
//                         $"Valor total em estoque: R${produtoDois.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
//                         $"Imposto: R${produtoDois.CalcularImposto().ToString("F2")}");

//       Produto produtoTres = new Produto("Monitor Dell 27", "Monitor Dell 27", 1889.00, 3, categoriaInformatica);

//       Console.WriteLine($"Id: {Produto.Id} \n " +
//                         $"Produto: {produtoTres.Nome} \n " +
//                         $"Descrição: {produtoTres.Descricao} \n " +
//                         $"Preço unitário: {produtoTres.PrecoUnitario} \n " +
//                         $"Quantidade: {produtoTres.QuantidadeEmEstoque} \n " +
//                         $"Categoria: {produtoTres.Categoria.Nome} \n " +
//                         $"Valor total em estoque: R${produtoTres.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
//                         $"Imposto: R${produtoTres.CalcularImposto().ToString("F2")}");

//       Console.ReadKey();
//     }
//   }
// }