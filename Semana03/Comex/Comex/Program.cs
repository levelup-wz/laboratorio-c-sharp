
using Comex;
using System;

Console.WriteLine("Teste de Categoria: \n");

Categoria Categoria1 = new Categoria();
Categoria1.Id = 1;
Categoria1.Nome = "INFORMÁTICA";
Categoria1.Status = "ativa";

Console.WriteLine("Id: " + Categoria1.Id + ", nome: " + Categoria1.Nome + ", status: " + Categoria1.Status);

Categoria Categoria2 = new Categoria();
Categoria2.Id = 2;
Categoria2.Nome = "MÓVEIS";
Categoria2.Status = "inativa";

Console.WriteLine("Id: " + Categoria2.Id + ", nome: " + Categoria2.Nome + ", status: " + Categoria2.Status);

Categoria Categoria3 = new Categoria();
Categoria3.Id = 3;
Categoria3.Nome = "LIVROS";
Categoria3.Status = "ativa";

Console.WriteLine("Id: " + Categoria3.Id + ", nome: " + Categoria3.Nome + ", status: " + Categoria3.Status);

Console.WriteLine();
Console.WriteLine("______________________________________________________________________________");

Console.WriteLine("Testando Produto: \n");

Produto produto1 = new Produto(1, "Notebook Samsung", 3523, 1, "Informática");
Console.WriteLine("Id: " + produto1.Id);
Console.WriteLine("Produto: " + produto1.Nome);
Console.WriteLine("Preço unitário R$ " + produto1.PrecoUnitario.ToString("N2"));
Console.WriteLine("Quantidade em estoque: " + produto1.Quantidade);
Console.WriteLine("Categoria: " + produto1.Categoria);
Console.WriteLine("Valor total em estoque R$ " + produto1.ValorEstoque().ToString("N2"));
Console.WriteLine("Valor imposto R$ " + produto1.Imposto().ToString("N2"));
Console.WriteLine();
Console.WriteLine("**********************************************");

Produto produto2 = new Produto(2, "Clean Architecture", 102.90, 2, "Livros");
Console.WriteLine("Id: " + produto2.Id);
Console.WriteLine("Produto: " + produto2.Nome);
Console.WriteLine("Preço unitário R$ " + produto2.PrecoUnitario.ToString("N2"));
Console.WriteLine("Quantidade em estoque: " + produto2.Quantidade);
Console.WriteLine("Categoria: " + produto2.Categoria);
Console.WriteLine("Valor total em estoque R$ " + produto2.ValorEstoque().ToString("N2"));
Console.WriteLine("Valor imposto R$ " + produto2.Imposto().ToString("N2"));
Console.WriteLine();
Console.WriteLine("**********************************************");

Produto produto3 = new Produto(3, "Monitor Dell 27", 1889, 3, "Informática");
Console.WriteLine("Id: " + produto3.Id);
Console.WriteLine("Produto: " + produto3.Nome);
Console.WriteLine("Preço unitário R$ " + produto3.PrecoUnitario.ToString("N2"));
Console.WriteLine("Quantidade em estoque: " + produto3.Quantidade);
Console.WriteLine("Categoria: " + produto3.Categoria);
Console.WriteLine("Valor total em estoque R$ " + produto3.ValorEstoque().ToString("N2"));
Console.WriteLine("Valor imposto R$ " + produto3.Imposto().ToString("N2"));
Console.WriteLine();
Console.WriteLine("______________________________________________________________________________");

Console.WriteLine("Testando Pedidos: \n");

Pedido pedido1 = new Pedido(1, "001.328.568-55", produto1, 1);
Console.WriteLine("Id: " + pedido1.Id);
Console.WriteLine("CPF: " + pedido1.Cliente);
Console.WriteLine("Data do pedido:" +pedido1.Data.ToString("dd/MM/yyyy"));
Console.WriteLine("Produto: " + produto1.Nome);
Console.WriteLine("Quantidade: "+ pedido1.Quantidade);
Console.WriteLine("Valor total do Pedido R$" +pedido1.ValorPedido().ToString("N2"));
Console.WriteLine("Valor Imposto R$" + pedido1.ImpostoTotal().ToString("N2"));
Console.WriteLine();
Console.WriteLine("**********************************************");

Pedido pedido2 = new Pedido(2, "380.462.678-88", produto2, 2);
Console.WriteLine("Id: " + pedido2.Id);
Console.WriteLine("CPF: " + pedido2.Cliente);
Console.WriteLine("Data do pedido:" + pedido2.Data.ToString("dd/MM/yyyy"));
Console.WriteLine("Produto: " + produto2.Nome);
Console.WriteLine("Quantidade: " + pedido2.Quantidade);
Console.WriteLine("Valor total do Pedido R$" + pedido2.ValorPedido().ToString("N2"));
Console.WriteLine("Valor Imposto R$" + pedido2.ImpostoTotal().ToString("N2"));
Console.WriteLine();
Console.WriteLine("**********************************************");

Pedido pedido3 = new Pedido(3, "778.569.258-64", produto3, 3);
Console.WriteLine("Id: " + pedido3.Id);
Console.WriteLine("CPF: " + pedido3.Cliente);
Console.WriteLine("Data do pedido:" + pedido3.Data.ToString("dd/MM/yyyy"));
Console.WriteLine("Produto: " + produto3.Nome);
Console.WriteLine("Quantidade: " + pedido3.Quantidade);
Console.WriteLine("Valor total do Pedido R$" + pedido3.ValorPedido().ToString("N2"));
Console.WriteLine("Valor Imposto R$" + pedido3.ImpostoTotal().ToString("N2"));
Console.WriteLine();
Console.WriteLine("**********************************************");



Console.ReadKey();
