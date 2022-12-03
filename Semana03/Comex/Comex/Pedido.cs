

//using Comex;
using System;
using System.Collections.Generic;
//using Comex;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Pedido
    {
       
        public Produto _produto { get; set; }
        

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public int Quantidade { get; set; }

        public Pedido(int id, string clinete, Produto produto, int quantidade)
        {
            Id = id;   
            Cliente= clinete;
            Data = DateTime.Now;
            _produto = produto;
            Quantidade= quantidade;
        }

        public double ValorPedido()
        {
            double ValorTotal = _produto.PrecoUnitario * Quantidade;
            return ValorTotal;
        }
                
        public double ImpostoTotal()
        {
            double TotalPagar = Quantidade * _produto.Imposto();
            return TotalPagar;
        }


    }
}

