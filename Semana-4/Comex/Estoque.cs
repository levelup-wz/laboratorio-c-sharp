using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Estoque
    {
        public int Capacidade { get; set; } = 1000;
        public int Ocupacao { get; set; }
        public decimal Montante { get; set; }

        public void RegistraEntrada(Produto produto)
        {
            {
                Capacidade -= produto.QuantidadeEmEstoque;
                Ocupacao += produto.QuantidadeEmEstoque;
                Montante += (decimal)produto.ValorTotalEmEstoque();
            }
        }

        public void RegistraSaida(Produto produto)
        {
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
