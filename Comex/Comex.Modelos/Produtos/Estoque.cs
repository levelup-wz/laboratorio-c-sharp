using System;
using Comex.Modelos.Exceptions;

namespace Comex.Modelos.Produtos
{
    public class Estoque
    {
        public int Capacidade { get; private set; }
        public int Ocupacao { get; private set; }
        public decimal Montante { get; private set; }

        public Estoque()
        {
            Capacidade = 1000;
            Ocupacao = 0;
            Montante = 0;
        }

        public void RegistraEntrada(Produto produto)
        {
            if (Ocupacao + produto.Estoque >= 1000)
            {
                throw new LimiteDeEstoqueExcedidoException("Estoque excedido!");
            }

            Capacidade -= produto.Estoque;
            Ocupacao += produto.Estoque;
            Montante += produto.ValorTotal();
        }

        public void RegistraSaida(Produto produto)
        {
            if (Ocupacao - produto.Estoque < 0)
            {
                throw new LimiteDeEstoqueExcedidoException("Não há produtos no estoque!");
            }

            Capacidade += produto.Estoque;
            Ocupacao -= produto.Estoque;
            Montante -= produto.ValorTotal();
        }
    }
}
