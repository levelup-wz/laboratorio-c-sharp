using Comex.Models.Exceptions;

namespace Comex.Models;

public class Estoque
{
   static public int Capacidade { get; set; } = 1000;
   static public int Ocupacao { get; set; }
   static public decimal Montante { get; set; }

    public static void RegistraEntrada(Produto produto)
    {
        if (produto.Quantidade_Em_Estoque > Capacidade)
        {
            throw new LimiteDeEstoqueExcedidoException("Capacidade de estoque excedida.");
        }


        Capacidade = (int)(Capacidade - produto.Quantidade_Em_Estoque);
        Ocupacao = (int)(Ocupacao + produto.Quantidade_Em_Estoque);
        Montante += (decimal)produto.CalculaValorTotalEmEstoque();
    }

    public static void RegistraSaida(Produto produto)
    {
        if (Ocupacao <= 0)
        {
            throw new LimiteDeEstoqueExcedidoException("Não existe mais produtos no estoque.");
        }

        Capacidade = (int)(Capacidade + produto.Quantidade_Em_Estoque);
        Ocupacao = (int)(Ocupacao - produto.Quantidade_Em_Estoque);
        Montante -= (decimal)produto.CalculaValorTotalEmEstoque();
    }

    public static void ExibirDadosEstoque()
    {
        Console.WriteLine($"Capacidade do estoque: {Capacidade}");
        Console.WriteLine($"Ocupação do estoque: {Ocupacao}");
        Console.WriteLine($"Montante do estoque: {Montante:N2}" + "\n");
    }
}
