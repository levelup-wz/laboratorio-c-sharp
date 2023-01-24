using Comex.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Estoque
    {
        public double Capacidade { get; set; } = 1000;
        public double Ocupacao { get; set; }
        public decimal Montante { get; set; }

        public void RegistraEntrada(Produto<int> produto)
        {
            if (produto.QuantidadeEmEstoque > Capacidade)
            {
                throw new LimiteDeEstoqueExcedidoException("O estoque não possui capacidade suficiente");
            }
            Capacidade -= produto.QuantidadeEmEstoque;
            Ocupacao += produto.QuantidadeEmEstoque;
            Montante += (decimal)produto.ValorTotalEmEstoque();
        }

        public void RegistraSaida(Produto<int> produto)
        {
            if (Ocupacao == 0)
            {
                throw new LimiteDeEstoqueExcedidoException("Não existe nenhum produto em estoque");
            }
            Capacidade += produto.QuantidadeEmEstoque;
            Ocupacao -= produto.QuantidadeEmEstoque;
            Montante -= (decimal)produto.ValorTotalEmEstoque();
        }

        public string InformacoesDoEstoque()
        {
            return $" Capacidade: {Capacidade}\n Ocupação: {Ocupacao}\n Montante: {Montante:C}";
        }
    }
}
