using Comex;
using Loja;
using Comex.Loja;
using Comex.Servico;

// Carro carroUno = new Carro();
// carroUno.TipoDirecao = OpcoesDeDirecao.Eletrica;

// Carro fiesta = new Carro();
// Carro.Id = 10;

// Carro ford = new Carro();
// Carro.Id = 20;

Produto pi = new ProdutoIsento("Bolacha", 10, 10, "ola");
Produto po = new Produto("Arroz", 15, 15, "cat1");
Produto macarrao = new Produto("Macarrão", 5, 15, "cat2");
Produto carne = new Produto("Maminha", 75, 15, "cat2");

Mercado mercadinho = new Mercado(); //Mercadinho ta aberto

List<Produto> carrinho1 = new List<Produto>();
carrinho1.Add(pi);
carrinho1.Add(po);

var somaDosProdutos = mercadinho.SomarValorProdutos(carrinho1); //venda
Console.WriteLine($"Total dos produtos vendidos: {somaDosProdutos} ");

List<Produto> carrinho2 = new List<Produto>();
carrinho2.Add(macarrao);
carrinho2.Add(carne);

var somaDosProdutos2 = mercadinho.SomarValorProdutos(carrinho2);
Console.WriteLine($"Total dos produtos vendidos: {somaDosProdutos2} ");

//pi.ValorTotalEmEstoque();
// Console.WriteLine($"O valor do imposto é: {pi.CalculaImposto()} ");
// Console.WriteLine($"O valor do imposto é: {po.CalculaImposto()} ");
// Console.WriteLine($"informações de {pi}");
// Console.WriteLine($"informações de {po}");



//Tributavel tributavel = new Produto("", 10, 10, "");
//tributavel.CalculaImposto();
// Carro carroPulse = new Carro();
// carroPulse.TipoDirecao2 = 2;

// Carro carroArgo = new Carro();
// carroArgo.TipoDirecao2 = 3;

Veiculo venda = new Veiculo();
