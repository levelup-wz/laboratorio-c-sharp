using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }
        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
        }

        public override string ToString()
        {
            return
                $"Nome: {Pedido.Cliente.NomeCompleto()}\n" +
                $"Data da compra: {Pedido.Data}\n" +
                $"Total do pedido: R$ {Pedido.ValorTotal():C}";
        }
    }
}
