using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime data = DateTime.Now;
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }

        public Pedido(int id, Cliente cliente, Produto produto, int quantidadeVendida)
        {
            Id = id;
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
