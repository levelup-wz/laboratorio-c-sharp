using Comex;

/*Categoria c1 = new Categoria("Informática");

Categoria c2 = new Categoria("Móveis");
c2.Status = OpcoesStatus.INATIVA;

Categoria c3 = new Categoria("Livros");

Console.WriteLine($"{c1.Nome} ({c1.Id} - {c1.Status})");
Console.WriteLine($"{c2.Nome} ({c2.Id} - {c2.Status})");
Console.WriteLine($"{c3.Nome} ({c3.Id} - {c3.Status})");
*/



/*Categoria c1 = new Categoria("Informática");
Categoria c2 = new Categoria("Livros");

Produto p1 = new Produto("Notebook Samsung", 3523.00, 1);
p1.ProdutoCategoria = c1;

Produto p2 = new Produto("Clean Architecture", 102.90, 2);
p2.ProdutoCategoria = c2;

Produto p3 = new Produto("Monitor Dell 27", 1889.00, 3);
p3.ProdutoCategoria = c1;

Console.WriteLine($"Id: {p1.Id}\nNome: {p1.Nome}\nCategoria: {p1.ProdutoCategoria.Nome}\nPreço unitário: R$ {p1.PrecoUnitario}\nImposto por unidade: R$ {Math.Round(p1.CalcularImposto(), 2)}\nQuantidade em estoque: {p1.QuantidadeEmEstoque}\n");
Console.WriteLine($"Id: {p2.Id}\nNome: {p2.Nome}\nCategoria: {p2.ProdutoCategoria.Nome}\nPreço unitário: R$ {p2.PrecoUnitario}\nImposto por unidade: R$ {Math.Round(p2.CalcularImposto(), 2)}\nQuantidade em estoque: {p2.QuantidadeEmEstoque}\n");
Console.WriteLine($"Id: {p3.Id}\nNome: {p3.Nome}\nCategoria: {p3.ProdutoCategoria.Nome}\nPreço unitário: R$ {p3.PrecoUnitario}\nImposto por unidade: R$ {Math.Round(p3.CalcularImposto(), 2)}\nQuantidade em estoque: {p3.QuantidadeEmEstoque}\n");*/



/*Categoria categoria1 = new Categoria("Informática");
Categoria categoria2 = new Categoria("Livros");

Produto produto1 = new Produto("Notebook Samsung", 3523.00, 1);
produto1.ProdutoCategoria = categoria1;

Produto produto2 = new Produto("Clean Architecture", 102.90, 2);
produto2.ProdutoCategoria = categoria2;

Produto produto3 = new Produto("Monitor Dell 27", 1889.00, 3);
produto3.ProdutoCategoria = categoria1;

Pedido pedido1 = new Pedido("012.345.678-90", produto1, 1);
Pedido pedido2 = new Pedido("098.765.432-10", produto2, 1);
Pedido pedido3 = new Pedido("234.567.890-12", produto3, 1);

Console.WriteLine(
    $"Id do pedido: {pedido1.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido1.Data)}\n" +
    $"Categoria: {pedido1.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido1.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido1.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido1.CalcularValorTotal()}\n"
);

Console.WriteLine(
    $"Id do pedido: {pedido2.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido2.Data)}\n" +
    $"Categoria: {pedido2.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido2.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido2.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido2.CalcularValorTotal()}\n"
);

Console.WriteLine(
    $"Id do pedido: {pedido3.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido3.Data)}\n" +
    $"Categoria: {pedido3.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido3.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido3.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido3.CalcularValorTotal()}\n"
);*/

Console.ReadKey();