using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
        private static int _id = 1;
        public int Id { get; }
        public DateTime Data = DateTime.Now;
        public Cliente Cliente { get; }
        public Produto Produto { get; }
        public double Quantidade_Vendida { get; }

        public Pedido(Cliente cliente, Produto produto, double quantidade_vendida)
        {
            Id = _id++;
            Cliente = cliente;
            Produto = produto;
            Quantidade_Vendida = quantidade_vendida;
        }

        public int DefineId()
        {
            return Id;
        }

        public double CalculaValorTotal()
        {
            double resultado = Produto.Preco_Unitario * Quantidade_Vendida;
            return resultado;
        }

        public double CalculaTotalDeImpostos()
        {
            double resultado = Quantidade_Vendida * Produto.CalculaImposto();
            return resultado;
        }
    }
}
