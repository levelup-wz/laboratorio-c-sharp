using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models
{
    public class NotaFiscal
    {
        private Pedido Pedido { get; set; }

        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
        }

        public override string ToString()
        {
            return
                $"Numero pedido: {Pedido.Id}\n" +
                $"Nome: {Pedido.Cliente.Nome}\n" +
                $"Data da compra: {Pedido.Date}\n" +
                $"Total do pedido: R$ {Pedido.CalcularValorTotal()}";
        }
    }
}
