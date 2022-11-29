using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void TestaPedido(Cliente andre, Cliente luisa, Cliente lara, Produto notebook, Produto monitor, Produto cleanArchiteture)
    {
        Console.WriteLine("\n----- TESTE DE PEDIDO -----\n");

        Pedido pedido1 = new Pedido(andre, notebook, 2);
        pedido1.ListarPedidos();
        Console.WriteLine("\n----------------------------------\n");

        Pedido pedido2 = new Pedido(luisa, monitor, 3);
        pedido2.ListarPedidos();
        Console.WriteLine("\n----------------------------------\n");

        Pedido pedido3 = new Pedido(lara, cleanArchiteture, 4);
        pedido3.ListarPedidos();
    }
}
