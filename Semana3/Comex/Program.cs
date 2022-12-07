// See https://aka.ms/new-console-template for more information
using Comex.Entidades;
using Comex.TestesClasses;

Console.WriteLine("Hello, World! - Semana 3");

#region Categorias
// CATEGORIAS
Categoria informatica = new Categoria("informática");
Categoria moveis = new Categoria("móveis", EStatus.Inativa);
Categoria livros = new Categoria("livros");

TestaCategoria(informatica, moveis, livros);
#endregion

#region Clientes
// CLIENTES
Cliente andre = new Cliente("Andre", "Sousa", "123456789-22", "7798802-0059", "Rua 1", "10", "Bem querer",
    "Candeias", "Vitoria da Conquista", "Bahia");

Cliente luisa = new Cliente("Luisa", "Sousa", "789654123-22", "7798802-0061", "Rua 2", "20", "Bem querer",
    "Candeias", "Vitoria da Conquista", "Bahia");

Cliente lara = new Cliente("Lara", "Sousa", "852963741-22", "7798802-0058", "Rua 3", "30", "Bem querer",
    "Candeias", "Vitoria da Conquista", "Bahia");
#endregion

#region Produtos
// PRODUTOS
Produto notebook = new Produto("Notebook Sansung", 3523.00, 1, informatica);
Produto cleanArchiteture = new Produto("Clean Architeture", 102.90, 2, livros);
Produto monitor = new Produto("Monitor Dell", 1889.00, 3, informatica);

TestaProduto(notebook, cleanArchiteture, monitor);
#endregion

#region Pedidos
//PEDIDOS
TestaPedido(andre, luisa, lara, notebook, cleanArchiteture, monitor);
#endregion

Console.WriteLine("\n*************** Testar produto Isento ***********\n");

TestaProdutoIsento testeProdutoIsento = new TestaProdutoIsento();
testeProdutoIsento.Main();

Console.WriteLine("\n*************** Testar Entrada de Produto no Estoque ***********\n");

TesteEntradaDeProdutoNoEstoque testeEntradaProdutoNoEstoque = new TesteEntradaDeProdutoNoEstoque();
testeEntradaProdutoNoEstoque.Main();

