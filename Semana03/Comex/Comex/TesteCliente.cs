
namespace Comex
{

    public class ClienteTeste
    {
        Cliente cliente1 = new Cliente("André Luiz", "Silva Azevêdo", "201.658.987-32", "(64) 98532-0766", "Rua João Pereira", "15A", 
            "Sem complemento", "Centro", "Goiandira", "Goiás");

        Cliente cliente2 = new Cliente("Maria", "Marques", "002.658.982-54", "(34) 98296-3246", "Rua Rondem Pacheco", "1523",
            "Apartamento 2A", "Santa Monica", "Uberlândia", "Minas Gerais");

        Cliente cliente3 = new Cliente("Julio", "Pereira da Silva", "245.985.658-82", "(64) 99924-3258", "Rua Maria de Paula", "502",
            "Casa 02", "Margon", "Catalão", "Goiás");

        public ClienteTeste() 
        {
            Console.WriteLine(cliente1.RetornaCliente());
            Console.WriteLine(cliente2.RetornaCliente());
            Console.WriteLine(cliente3.RetornaCliente());
        }   

    }
}