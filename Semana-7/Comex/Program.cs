using Comex.TestaModels;
using Comex.Models.Exceptions;
using Comex.Models;

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
    Console.WriteLine("Testa Saída da Nota Fiscal:");
    Console.WriteLine("-----------------------------------");
    var notaFiscal = new NotaFiscal(new Pedido(new Cliente("Saulo", "Alves", "99999999999", "99", "s", "2", "casa", "ibotirama", "ba"), new Produto("Notebook", 10.00, 10, "informatica"), 10));
    Console.WriteLine(notaFiscal.ToString());
    Console.WriteLine(" ");
    Console.WriteLine("Testa Cálculo do Frete:");
    Console.WriteLine("-----------------------------------");
    TestaFrete.Main();
    Console.WriteLine(" ");
}
catch (LimiteDeEstoqueExcedidoException ex)
{
    Console.WriteLine(ex.Message);
}
