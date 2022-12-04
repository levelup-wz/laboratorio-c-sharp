namespace Comex.Testes
{
  public class TestaPedido
  {
    public static void Main(string[] args)
    {
      Categoria categoriaInformatica = new Categoria("Informática");
      Produto produtoUm = new Produto(1, "Notebook Samsung", "Notebook Samsung 8GB", 3523.00, 1, categoriaInformatica);
      Cliente clienteUm = new Cliente(1, "João", "Oliveira", "895.145.878-55", "31 99999-9999", "Rua Madagascar", "123", "Apto 125", "Centro", "Belo Horizonto", "MG");
      Pedido pedidoUm = new Pedido(1, DateTime.Now, clienteUm, produtoUm, 1);

      Console.WriteLine($"Pedido: {pedidoUm.Id} \n " +
                        $"Data: {pedidoUm.Data} \n " +
                        $"Cliente: {pedidoUm.Cliente.ObterNomeCompleto()} \n " +
                        $"Endereço: {pedidoUm.Cliente.ObterEnderecoCompleto()} \n " +
                        $"Produto: {pedidoUm.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoUm.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoUm.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoUm.CalcularValorTotalDeImpostos().ToString("F2")}");

      Categoria categoriaLivros = new Categoria("Livros");
      Produto produtoDois = new Produto(2, "Clean Architecture", "Clean Architecture", 102.90, 2, categoriaLivros);
      Cliente clienteDois = new Cliente(2, "Maria", "Gonçalves", "895.145.878-55", "11 99999-9999", "Rua das Graças", "358", "Apto 12", "Centro", "São Paulo", "SP");
      Pedido pedidoDois = new Pedido(2, DateTime.Now, clienteDois, produtoDois, 2);

      Console.WriteLine($"Pedido: {pedidoDois.Id} \n " +
                        $"Data: {pedidoDois.Data} \n " +
                        $"Cliente: {pedidoDois.Cliente.ObterNomeCompleto()} \n " +
                        $"Endereço: {pedidoDois.Cliente.ObterEnderecoCompleto()} \n " +
                        $"Produto: {pedidoDois.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoDois.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoDois.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoDois.CalcularValorTotalDeImpostos().ToString("F2")}");

      Produto produtoTres = new Produto(3, "Monitor Dell 27", "Monitor Dell 27", 1889.00, 3, categoriaInformatica);
      Cliente clienteTres = new Cliente(3, "José", "Silva", "895.145.878-55", "21 99999-9999", "Rua Bela", "251", "Apto 26", "Centro", "Rio de Janeiro", "RJ");
      Pedido pedidoTres = new Pedido(3, DateTime.Now, clienteTres, produtoTres, 3);

      Console.WriteLine($"Pedido: {pedidoTres.Id} \n " +
                        $"Data: {pedidoTres.Data} \n " +
                        $"Cliente: {pedidoTres.Cliente.ObterNomeCompleto()} \n " +
                        $"Endereço: {pedidoTres.Cliente.ObterEnderecoCompleto()} \n " +
                        $"Produto: {pedidoTres.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoTres.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoTres.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoTres.CalcularValorTotalDeImpostos().ToString("F2")}");


    }
  }
}