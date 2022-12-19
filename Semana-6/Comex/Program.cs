using Comex.TestaModels;
using Comex.Models.Exceptions;

try
{
    Console.WriteLine("Testa Produto Isento:");
    Console.WriteLine("-----------------------------------");
    TestaProdutoIsento.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Entrada De Produtos No Estoque:");
    Console.WriteLine("-----------------------------------");
    TestaEntradaDeProdutosNoEstoque.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Saída De Produtos No Estoque:");
    Console.WriteLine("-----------------------------------");
    TestaSaidaDeProdutoNoEstoque.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Validação de Categoria:");
    Console.WriteLine("-----------------------------------");
    TestaValidacaoDeCategoria.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Validação de Produtos:");
    Console.WriteLine("-----------------------------------");
    TestaValidacaoDeProdutos.Main();
    Console.WriteLine(" ");
}
catch (LimiteDeEstoqueExcedidoException ex)
{
    Console.WriteLine(ex.Message);
}
