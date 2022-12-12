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
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void ResistrarSaida (Produto produto)
        {
            try
            {
                VerificarSaida(produto);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void VerificarEntrada(Produto produto)
        {
            if (produto._quantidadeEstoque > Capacidade)
            {
                throw new Exception($"A quantidade do estoque: {produto._quantidadeEstoque} do produto: {produto._nome} é maior que a capacidade disponível: {Capacidade}.");
            }
            else
            {
                Capacidade -= produto._quantidadeEstoque;
                Ocupacao += produto._quantidadeEstoque;
                Montante += (decimal)produto.CalcularValorEstoque();
                Console.WriteLine($"Produto: {produto._nome} adicionado com sucesso!");
            }
        }

        public void VerificarSaida(Produto produto)
        {
            if (produto._quantidadeEstoque > Ocupacao)
            {
                throw new Exception($"Não foi possível efetuar a saída do produto: {produto._nome}, pois não existe no estoque.");
            }
            else
            {
                Capacidade += produto._quantidadeEstoque;
                Ocupacao -= produto._quantidadeEstoque;
                Montante -= (decimal)produto.CalcularValorEstoque();
                Console.WriteLine($"Produto: {produto._nome} retirado com sucesso!");
            }
        }

        public void ListarEstoque ()
        {
            Console.WriteLine("\n----------------Listando Estoque ----------------------\n");
            Console.WriteLine($"Capacidade: {capacidade} - Ocupação: {Ocupacao} - Montante: R$ {Montante.ToString("n2")}");
        }
    }
}
