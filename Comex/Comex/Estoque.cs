using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Estoque
    {
        static public int Capacidade { get; private set; } = 1000;
        static public int Ocupacao { get; private set; }
        static public decimal Montante { get; private set; }
        public Produto Produto { get; set; }

        public void RegistraEntrada(Produto produto) 
        {
            Capacidade -= produto.QuantidadeEmEstoque;
            Ocupacao += produto.QuantidadeEmEstoque;
            Montante += Convert.ToDecimal(produto.CalcularValorTotal());
        }

        public void RegistraSaida(Produto produto)
        {
            Capacidade += produto.QuantidadeEmEstoque;
            Ocupacao -= produto.QuantidadeEmEstoque;
            Montante -= Convert.ToDecimal(produto.CalcularValorTotal());
        }
    }
}
