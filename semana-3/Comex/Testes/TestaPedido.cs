namespace Comex.Testes
{
  public class TestaPedido
  {
    public static void Main(string[] args)
    {
      Categoria categoriaInformatica = new Categoria("Informática");
      Produto produtoUm = new Produto(1, "Notebook Samsung", "Notebook Samsung 8GB", 3523.00, 1, categoriaInformatica);
      Pedido pedidoUm = new Pedido(1, DateTime.Now, "João", produtoUm, 1);

      Console.WriteLine($"Pedido: {pedidoUm.Id} \n " +
                        $"Data: {pedidoUm.Data} \n " +
                        $"Cliente: {pedidoUm.Cliente} \n " +
                        $"Produto: {pedidoUm.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoUm.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoUm.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoUm.CalcularValorTotalDeImpostos().ToString("F2")}");

      Categoria categoriaLivros = new Categoria("Livros");
      Produto produtoDois = new Produto(2, "Clean Architecture", "Clean Architecture", 102.90, 2, categoriaLivros);
      Pedido pedidoDois = new Pedido(2, DateTime.Now, "Maria", produtoDois, 2);

      Console.WriteLine($"Pedido: {pedidoDois.Id} \n " +
                        $"Data: {pedidoDois.Data} \n " +
                        $"Cliente: {pedidoDois.Cliente} \n " +
                        $"Produto: {pedidoDois.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoDois.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoDois.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoDois.CalcularValorTotalDeImpostos().ToString("F2")}");

      Produto produtoTres = new Produto(3, "Monitor Dell 27", "Monitor Dell 27", 1889.00, 3, categoriaInformatica);
      Pedido pedidoTres = new Pedido(3, DateTime.Now, "José", produtoTres, 3);

      Console.WriteLine($"Pedido: {pedidoTres.Id} \n " +
                        $"Data: {pedidoTres.Data} \n " +
                        $"Cliente: {pedidoTres.Cliente} \n " +
                        $"Produto: {pedidoTres.Produto.Nome} \n " +
                        $"Quantidade vendida: {pedidoTres.QuantidadeVendida} \n " +
                        $"Valor total: R${pedidoTres.CalcularValorTotal().ToString("F2")} \n " +
                        $"Valor total de impostos: R${pedidoTres.CalcularValorTotalDeImpostos().ToString("F2")}");


    }
  }
}