using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestaPedido
{
    public static void Main()
    {
        Categoria informatica = new Categoria("informática");
        Categoria livros = new Categoria("livros");

        Produto notebook = new Produto("Notebook Sansung", 3523.00, 1, informatica);
        Produto cleanArchiteture = new Produto("Clean Architeture", 102.90, 2, livros); 
        Produto monitor = new Produto("Monitor Dell", 1889.00, 3, informatica); 

        Cliente andre = new Cliente("Andre", "Sousa", "123456789-22", "7798802-0059", "Rua 1", "10", "Bem querer",
            "Candeias", "Vitoria da Conquista", "Bahia");

        Cliente luisa = new Cliente("Luisa", "Sousa", "789654123-22", "7798802-0061", "Rua 2", "20", "Bem querer",
            "Candeias", "Vitoria da Conquista", "Bahia");

        Cliente lara = new Cliente("Lara", "Sousa", "852963741-22", "7798802-0058", "Rua 3", "30", "Bem querer",
            "Candeias", "Vitoria da Conquista", "Bahia");

        Console.WriteLine("\n----- TESTE DE PEDIDO -----\n");

        Pedido pedido1 = new Pedido(andre, notebook, 2);
        Console.WriteLine(pedido1.ListarPedidos());
        Console.WriteLine("\n----------------------------------\n");

        Pedido pedido2 = new Pedido(luisa, monitor, 3);
        Console.WriteLine(pedido2.ListarPedidos());
        Console.WriteLine("\n----------------------------------\n");

        Pedido pedido3 = new Pedido(lara, cleanArchiteture, 4);
        Console.WriteLine(pedido3.ListarPedidos());
    }
}
