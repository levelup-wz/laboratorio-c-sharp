using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Comex
{
    public class Estoque
    {
       static public int Capacidade { get; set; } = 1000;
       static public int Ocupacao { get; set; }
       static public decimal Montante { get; set; }

        public void RegistraEntrada(Produto produto)
        {
            if (produto.Quantidade_Em_Estoque > Capacidade)
            {
                throw new LimiteDeEstoqueExcedidoException("Capacidade de estoque excedida.");
            }


            Capacidade = (int)(Capacidade - produto.Quantidade_Em_Estoque);
            Ocupacao = (int)(Ocupacao + produto.Quantidade_Em_Estoque);
            Montante = Montante + (decimal)produto.CalculaValorTotalEmEstoque();
        }

        public void RegistraSaida(Produto produto)
        {
            if (Ocupacao <= 0)
            {
                throw new LimiteDeEstoqueExcedidoException("Não existe mais produtos no estoque.");
            }

            Capacidade = (int)(Capacidade + produto.Quantidade_Em_Estoque);
            Ocupacao = (int)(Ocupacao - produto.Quantidade_Em_Estoque);
            Montante = Montante - (decimal)produto.CalculaValorTotalEmEstoque();
        }

        public void ExibirDadosEstoque()
        {
            Console.WriteLine($"Capacidade do estoque: {Capacidade}");
            Console.WriteLine($"Ocupação do estoque: {Ocupacao}");
            Console.WriteLine($"Montante do estoque: {Montante.ToString("N2")}" + "\n");
        }
    }
}
