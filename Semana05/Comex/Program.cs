
using Comex;
using Comex.Testes;
using System;
using Comex.Models;



Console.WriteLine("Teste Categoria:");
Console.WriteLine("----------------------------------");
//new CategoriaTeste();
CategoriaTeste.Main();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Produto:");
Console.WriteLine("----------------------------------");
ProdutoTeste.Main();
//new ProdutoTeste();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Clinete");
Console.WriteLine("----------------------------------");
new ClienteTeste();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Pedido:");
Console.WriteLine("----------------------------------");
new PedidoTeste();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Produto Isento:");
Console.WriteLine("----------------------------------");
new ProdutoIsentoteste();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Entradas do Estoque:");
Console.WriteLine("----------------------------------");
//TestaEntradaDeProdutoNoEstoque.Main();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Saída do Estoque:");
Console.WriteLine("----------------------------------");
//TestaSaidaDeProdutoNoEstoque.Main();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Validação de Categoria:");
Console.WriteLine("----------------------------------");
TestaValidacaoDeCategoria.Main();
Console.WriteLine("----------------------------------");
Console.WriteLine("Teste Validação do Produto:");
Console.WriteLine("----------------------------------");
TestaValidacaoDeProdutos.Main();



Console.WriteLine("Telce enter para sair");
Console.ReadKey();

