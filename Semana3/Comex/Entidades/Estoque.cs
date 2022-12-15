using Comex.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Estoque
    {
        private int capacidade = 1000;
        public int Capacidade
        {
            get
            {
                return capacidade;
            }
            set
            {
                capacidade = value;
            }
        }
        
        public int Ocupacao { get; private set; }
        public decimal Montante { get; private set; }
       

        public void RegistrarEntrada (Produto produto)
        {
            try
            {
                VerificarEntrada(produto);
            }
            catch (LimiteDeEstoqueExcedidoException error)
            {
                // Console.WriteLine(error.StackTrace);
                Console.WriteLine(error.Message);
            }
        }

        public void ResistrarSaida (Produto produto)
        {
            try
            {
                VerificarSaida(produto);
            }
            catch (LimiteDeEstoqueExcedidoException error)
            {
                // Console.WriteLine(error.StackTrace);
                Console.WriteLine(error.Message);
            }
        }

        public void VerificarEntrada(Produto produto)
        {
            if (produto.QuantidadeEstoque > Capacidade)
            {
                throw new LimiteDeEstoqueExcedidoException($"A quantidade do estoque: {produto.QuantidadeEstoque} do produto: {produto.Nome} é maior que a capacidade disponível: {Capacidade}.");
            }
            else
            {
                Capacidade -= produto.QuantidadeEstoque;
                Ocupacao += produto.QuantidadeEstoque;
                Montante += (decimal)produto.CalcularValorEstoque();
                Console.WriteLine($"Produto: {produto.Nome} adicionado com sucesso!");
            }
        }

        public void VerificarSaida(Produto produto)
        {
            if (produto.QuantidadeEstoque > Ocupacao)
            {
                throw new LimiteDeEstoqueExcedidoException($"Não foi possível efetuar a saída do produto: {produto.Nome}, pois não existe no estoque.");
            }
            else
            {
                Capacidade += produto.QuantidadeEstoque;
                Ocupacao -= produto.QuantidadeEstoque;
                Montante -= (decimal)produto.CalcularValorEstoque();
                Console.WriteLine($"Produto: {produto.Nome} retirado com sucesso!");
            }
        }

        public void ListarEstoque ()
        {
            Console.WriteLine("\n----------------Listando Estoque ----------------------\n");
            Console.WriteLine($"Capacidade: {capacidade} - Ocupação: {Ocupacao} - Montante: R$ {Montante.ToString("n2")}");
        }
    }
}
