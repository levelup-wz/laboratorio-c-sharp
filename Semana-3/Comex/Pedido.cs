using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
        private static int _id = 0;
        public int Id { get; set; }
        public DateTime data = DateTime.Now;
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }

        public Pedido(Cliente cliente, Produto produto, int quantidadeVendida)
        {
            Id = ++_id;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida= quantidadeVendida;
        }

        public double ValorTotal()
        {   
            return QuantidadeVendida * Produto.PrecoUnitario;
        }

        public double TotalDeImpostos()
        {
            return QuantidadeVendida * Produto.CalculaImposto();
        }
    }
}
