// See https://aka.ms/new-console-template for more information
using Comex.Entidades;
using Comex.TestesClasses;

Console.WriteLine("Hello, World! - Semana 3");

// CATEGORIAS
TestaCategoria.Main();

// PRODUTOS
TestaProduto.Main();

// PEDIDOS
TestaPedido.Main();

TestaProdutoIsento.Main();

Console.WriteLine("*************** Testar Entrada de Produto no Estoque ***********");

TesteEntradaDeProdutoNoEstoque testeEntradaProdutoNoEstoque = new TesteEntradaDeProdutoNoEstoque();
testeEntradaProdutoNoEstoque.Main();

Console.WriteLine("\n*************** Testar Saída de Produto no Estoque ***********");

TestaSaidaDeProdutoNoEstoque testaSaidaDeProdutoNoEstoque = new TestaSaidaDeProdutoNoEstoque();
testaSaidaDeProdutoNoEstoque.Main();

