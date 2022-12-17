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
            // Verifica se a quantidade do produto a ser inserida no estoque excede a capacidade, que por padrão é 1000
            if (Capacidade - produto.QuantidadeEmEstoque < 0)
            {
                throw new EstoqueException("A capacidade do estoque é limitada a 1000 unidades do produto.");
            }
            Capacidade -= produto.QuantidadeEmEstoque;
            Ocupacao += produto.QuantidadeEmEstoque;
            Montante += Convert.ToDecimal(produto.CalcularValorTotal());
        }

        public void RegistraSaida(Produto produto)
        {
            // Verifica se o estoque está vazio
            if (Ocupacao == 0)
            {
                throw new EstoqueException("Não é possível registrar saída de produto(s), pois o estoque está vazio.");
            }
            Capacidade += produto.QuantidadeEmEstoque;
            Ocupacao -= produto.QuantidadeEmEstoque;
            Montante -= Convert.ToDecimal(produto.CalcularValorTotal());
        }
    }
}
