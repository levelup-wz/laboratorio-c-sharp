using Comex;
using System.ComponentModel;

namespace Comex
{
    public class PedidoTeste
    {
        Cliente cliente1 = new Cliente("André Luiz", "Silva Azevêdo", "201.658.987-32", "(64) 98532-0766", "Rua João Pereira", "15A",
            "Sem complemento", "Centro", "Goiandira", "Goiás");

        Cliente cliente2 = new Cliente("Maria", "Marques", "002.658.982-54", "(34) 98296-3246", "Rua Rondem Pacheco", "1523",
            "Apartamento 2A", "Santa Monica", "Uberlândia", "Minas Gerais");

        Cliente cliente3 = new Cliente("Julio", "Pereira da Silva", "245.985.658-82", "(64) 99924-3258", "Rua Maria de Paula", "502",
            "Casa 02", "Margon", "Catalão", "Goiás");

        Produto produto1 = new Produto ("Notebook Samsung", 3523, 1, "Informática");
        Produto produto2 = new Produto("Clean Architecture", 102.90, 2, "Livros");
        Produto produto3 = new Produto("Monitor Dell 27", 1889, 3, "Informática");



        public PedidoTeste()
        {
            Pedido pedido1 = new Pedido(cliente1, produto1, 1);
            Pedido pedido2 = new Pedido(cliente2, produto2, 2);
            Pedido pedido3 = new Pedido(cliente3, produto3, 3);

            Console.WriteLine(pedido1.RetornaInfosPedido());
            Console.WriteLine(pedido2.RetornaInfosPedido());
            Console.WriteLine(pedido3.RetornaInfosPedido());
        }

    }

}