using Comex.Entidades;
using Comex.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.TestesClasses
{
    public class TestaItemsDoPedido
    {
        public static void Main()
        {
            var informatica = new Categoria("Informática");
            var monitor = new Produto("Monitor", 300.00, 5, informatica);
            var itemsDoPedido = new ItemsDoPedido(monitor, 3);
            
            Console.WriteLine($"O Total do pedido é {itemsDoPedido.Total}");
        }
    }
}
