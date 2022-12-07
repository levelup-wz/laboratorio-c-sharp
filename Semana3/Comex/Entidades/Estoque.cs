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
            Capacidade -= produto._quantidadeEstoque;
            Ocupacao += produto._quantidadeEstoque;
            Montante += (decimal)produto.CalcularValorEstoque();
        }

        public void ResistrarSaida (Produto produto)
        {
            Capacidade += produto._quantidadeEstoque;
            Ocupacao -= produto._quantidadeEstoque;
            Montante -= (decimal)produto.CalcularValorEstoque();
        }

        public void ListarEstoque ()
        {
            Console.WriteLine("\n----------------Listando Estoque ----------------------\n");
            Console.WriteLine($"Capacidade: {capacidade} - Ocupação: {Ocupacao} - Montante: R$ {Montante.ToString("n2")}");
        }
    }
}
