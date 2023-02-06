// namespace Comex.Testes
// {
//   public class TestaValidacaoDeProdutos
//   {
//     public static void Main(string[] args)
//     {
//       Categoria categoriaInformatica = new Categoria("Informática");
//       Produto produto = new Produto("Not", "Notebook Samsung 8GB", 5, 10, categoriaInformatica);

//       Console.WriteLine($"Id: {Produto.Id} \n " +
//                         $"Produto: {produto.Nome} \n " +
//                         $"Descrição: {produto.Descricao} \n " +
//                         $"Preço unitário: {produto.PrecoUnitario} \n " +
//                         $"Quantidade: {produto.QuantidadeEmEstoque} \n " +
//                         $"Categoria: {produto.Categoria.Nome} \n " +
//                         $"Valor total em estoque: R${produto.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
//                         $"Imposto: R${produto.CalcularImposto().ToString("F2")}");
    
//       Categoria categoriaSaude = new Categoria("Saúde");
//       ProdutoIsento produtoInsento = new ProdutoIsento("Vacina", "Vacina ...", 0, 1000, categoriaSaude);

//       Console.WriteLine($"Id: {Produto.Id} \n " +
//                         $"Produto: {produtoInsento.Nome} \n " +
//                         $"Descrição: {produtoInsento.Descricao} \n " +
//                         $"Preço unitário: {produtoInsento.PrecoUnitario} \n " +
//                         $"Quantidade: {produtoInsento.QuantidadeEmEstoque} \n " +
//                         $"Categoria: {produtoInsento.Categoria.Nome} \n " +
//                         $"Valor total em estoque: R${produtoInsento.CalculaValorTotalEmEstoque().ToString("F2")} \n " +
//                         $"Imposto: R${produtoInsento.CalcularImposto().ToString("F2")}");

//     }
//   }
// }