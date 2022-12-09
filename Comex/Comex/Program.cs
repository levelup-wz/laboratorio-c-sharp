using Comex;
using Comex.Testes;

/* Testa Categoria

Categoria c1 = new Categoria("Informática");

Categoria c2 = new Categoria("Móveis");
c2.Status = OpcoesStatus.INATIVA;

Categoria c3 = new Categoria("Livros");

Console.WriteLine($"{c1.Nome} ({c1.Id} - {c1.Status})");
Console.WriteLine($"{c2.Nome} ({c2.Id} - {c2.Status})");
Console.WriteLine($"{c3.Nome} ({c3.Id} - {c3.Status})");
*/



/* Testa Pedido

Categoria c1 = new Categoria("Informática");
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



/* Testa Pedido - Cliente

Categoria categoria1 = new Categoria("Informática");
Categoria categoria2 = new Categoria("Livros");

Produto produto1 = new Produto("Notebook Samsung", 3523.00, 1);
produto1.ProdutoCategoria = categoria1;

Produto produto2 = new Produto("Clean Architecture", 102.90, 2);
produto2.ProdutoCategoria = categoria2;

Produto produto3 = new Produto("Monitor Dell 27", 1889.00, 3);
produto3.ProdutoCategoria = categoria1;

Cliente cliente1 = new Cliente("José", "Rodrigues", 01234567890, "(61) 9 9352-9033", "Rua das Jabuticabeiras", 5, "Apto 201", "Setor 9", "Valparaíso", "Goiás");


Pedido pedido1 = new Pedido(cliente1, produto1, 1);
Pedido pedido2 = new Pedido(cliente1, produto2, 1);
Pedido pedido3 = new Pedido(cliente1, produto3, 1);

Console.WriteLine(
    $"Id do pedido: {pedido1.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido1.Data)}\n" +
    $"Categoria: {pedido1.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido1.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido1.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido1.CalcularValorTotal()}\n" +
    $"Cliente {pedido1.ClientePedido.ObterNomeCompleto()}\n" +
    $"{pedido1.ClientePedido.ObterEndereco()}\n"
);

Console.WriteLine(
    $"Id do pedido: {pedido2.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido2.Data)}\n" +
    $"Categoria: {pedido2.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido2.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido2.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido2.CalcularValorTotal()}\n" +
    $"Cliente {pedido2.ClientePedido.ObterNomeCompleto()}\n" +
    $"{pedido2.ClientePedido.ObterEndereco()}\n"
);

Console.WriteLine(
    $"Id do pedido: {pedido3.Id}\n" +
    $"Data: {String.Format("{0:dd/MM/yyyy}", pedido3.Data)}\n" +
    $"Categoria: {pedido3.PedidoProduto.ProdutoCategoria.Nome}\n" +
    $"Nome do produto: {pedido3.PedidoProduto.Nome}\n" +
    $"Total de Impostos: R$ {Math.Round(pedido3.CalcularImposto(), 2)}\n" +
    $"Valor Total: R$ {pedido3.CalcularValorTotal()}\n" +
    $"Cliente {pedido3.ClientePedido.ObterNomeCompleto()}\n" +
    $"{pedido3.ClientePedido.ObterEndereco()}\n"
);*/

Categoria saude = new Categoria("Saúde");
Categoria livros = new Categoria("Livros");
Categoria informatica = new Categoria("Informática");

ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 1000, saude);
ProdutoIsento useACabecaJava = new ProdutoIsento("Use a cabeça: Java", 112.90, 5, livros);
Produto macbookPro = new Produto("Macbook Pro", 20000.00, 11, informatica);

Console.WriteLine(
    $"Id: {vacina.Id}\n" +
    $"Nome: {vacina.Nome}\n" +
    $"Categoria: {vacina.ProdutoCategoria.Nome}\n" +
    $"Preço unitário: {vacina.PrecoUnitario:C}\n" +
    $"Imposto por unidade: {vacina.CalcularImposto():C}\n" +
    $"Quantidade em estoque: {vacina.QuantidadeEmEstoque}\n"
);

Console.WriteLine(
    $"Id: {useACabecaJava.Id}\n" +
    $"Nome: {useACabecaJava.Nome}\n" +
    $"Categoria: {useACabecaJava.ProdutoCategoria.Nome}\n" +
    $"Preço unitário: {useACabecaJava.PrecoUnitario:C}\n" +
    $"Imposto por unidade: {useACabecaJava.CalcularImposto():C}\n" +
    $"Quantidade em estoque: {useACabecaJava.QuantidadeEmEstoque}\n"
);

Console.WriteLine(
    $"Id: {macbookPro.Id}\n" +
    $"Nome: {macbookPro.Nome}\n" +
    $"Categoria: {macbookPro.ProdutoCategoria.Nome}\n" +
    $"Preço unitário: {macbookPro.PrecoUnitario:C}\n" +
    $"Imposto por unidade: {macbookPro.CalcularImposto():C}\n" +
    $"Quantidade em estoque: {macbookPro.QuantidadeEmEstoque}\n"
);

Console.ReadKey();