using Comex;
Console.WriteLine("TestaCategoria:" + "\n");
Categoria categoria1 = new Categoria();
categoria1.Id = 1;
categoria1.Nome = "INFORMÁTICA";
categoria1.Status = "ATIVA";

Categoria categoria2 = new Categoria();
categoria2.Id = 2;
categoria2.Nome = "MÓVEIS";
categoria2.Status = "INATIVA";

Categoria categoria3 = new Categoria();
categoria3.Id = 3;
categoria3.Nome = "LIVROS";
categoria3.Status = "ATIVA";

Console.WriteLine($"{categoria1.Nome} ({categoria1.Id} - {categoria1.Status})");
Console.WriteLine($"{categoria2.Nome} ({categoria2.Id} - {categoria2.Status})");
Console.WriteLine($"{categoria3.Nome} ({ categoria3.Id} - {categoria3.Status})" + "\n");

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("TestaProduto:" + "\n");
Produto produto1 = new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática");

Produto produto2 = new Produto(2, "Clean Architecture", 102.90, 2, "Livros");

Produto produto3 = new Produto(3, "Monitor Dell 27", 1889.00, 3, "Informática");

Console.WriteLine($"{produto1.Categoria} ({produto1.Id} - {produto1.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto1.Quantidade_Em_Estoque}");
Console.WriteLine($"Valor total em estoque: {produto1.CalculaValorTotalEmEstoque().ToString("N2")}");
Console.WriteLine($"Preço unitário: {produto1.Preco_Unitario}");
Console.WriteLine($"Valor de Imposto: {produto1.CalculaImposto().ToString("N2")}" + "\n");

Console.WriteLine($"{produto2.Categoria} ({produto2.Id} - {produto2.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto2.Quantidade_Em_Estoque}");
Console.WriteLine($"Valor total em estoque: {produto2.CalculaValorTotalEmEstoque().ToString("N2")}");
Console.WriteLine($"Preço unitário: {produto2.Preco_Unitario}");
Console.WriteLine($"Valor de Imposto: {produto2.CalculaImposto().ToString("N2")}" + "\n");

Console.WriteLine($"{produto3.Categoria} ({produto3.Id} - {produto3.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto3.Quantidade_Em_Estoque}");
Console.WriteLine($"Valor total em estoque: {produto3.CalculaValorTotalEmEstoque().ToString("N2")}");
Console.WriteLine($"Preço unitário: {produto3.Preco_Unitario}");
Console.WriteLine($"Valor de Imposto: {produto3.CalculaImposto().ToString("N2")}" + "\n");

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("TestaPedido:" + "\n");
Pedido pedido1 = new Pedido(1, "111.333.444-55", new Produto(1, "Notebook Samsung", 3523.00, 1, "Informática"), 1);
Console.WriteLine($"Id do pedido: {pedido1.Id}");
Console.WriteLine($"Data do pedido: { pedido1.Data}");
Console.WriteLine($"CPF do pedido: {pedido1.Cliente}");
Console.WriteLine($"Produto do pedido: {pedido1.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido1.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido1.Quantidade_Vendida}");
Console.WriteLine($"Valor total vendido: {pedido1.CalculaValorTotal().ToString("N2")}");
Console.WriteLine($"Total de impostos: { pedido1.CalculaTotalDeImpostos().ToString("N2")}" + "\n");

Pedido pedido2 = new Pedido(2, "222.333.444-55", new Produto(2, "Clean Architecture", 102.90, 2, "Livros"), 2);
Console.WriteLine($"Id do pedido: {pedido2.Id}");
Console.WriteLine($"Data do pedido: {pedido2.Data}");
Console.WriteLine($"CPF do pedido: {pedido2.Cliente}");
Console.WriteLine($"Produto do pedido: {pedido2.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido2.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido2.Quantidade_Vendida}");
Console.WriteLine($"Valor total vendido: {pedido2.CalculaValorTotal().ToString("N2")}");
Console.WriteLine($"Total de impostos: {pedido2.CalculaTotalDeImpostos().ToString("N2")}" + "\n");

Pedido pedido3 = new Pedido(3, "333.444.555-66", new Produto(3, "Monitor Dell 27", 1889.00, 3, "Informática"), 3);
Console.WriteLine($"Id do pedido: {pedido3.Id}");
Console.WriteLine($"Data do pedido: {pedido3.Data}");
Console.WriteLine($"CPF do pedido: {pedido3.Cliente}");
Console.WriteLine($"Produto do pedido: {pedido3.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido3.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido3.Quantidade_Vendida}");
Console.WriteLine($"Valor total vendido: {pedido3.CalculaValorTotal().ToString("N2")}");
Console.WriteLine($"Total de impostos: {pedido3.CalculaTotalDeImpostos().ToString("N2")}" + "\n");

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Tecle enter para fechar o programa...");
Console.ReadKey();