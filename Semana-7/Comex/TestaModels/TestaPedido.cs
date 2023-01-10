using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaPedido
    {
        Cliente cliente1 = new Cliente("Saulo", "Alves Magalhães", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        Cliente cliente2 = new Cliente("André", "Sousa", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        Cliente cliente3 = new Cliente("Davi", "Kennedy", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");

        public TestaPedido()
        {

            Pedido Pedido1 = new Pedido(cliente1, new Produto("Notebook Samsung", 3523.00, 1, "Informática"), 10);
            Pedido Pedido2 = new Pedido(cliente2, new Produto("Clean Architecture", 102.90, 2, "Livros"), 5);
            Pedido Pedido3 = new Pedido(cliente3, new Produto("Monitor Dell 27", 1889.00, 3, "Informática"), 2);
            
            Console.WriteLine($" Nome do Cliente: {Pedido1.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido1.Cliente.EnderecoCompleto()}\n Nome do Produto: {Pedido1.Produto.Nome}\n Categoria: {Pedido1.Produto.Categoria}\n Valor total:{Pedido1.ValorTotal():C2}\n Impostos:{Pedido1.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome do Cliente: {Pedido2.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido2.Cliente.EnderecoCompleto()}\n Nome do Produto: {Pedido2.Produto.Nome}\n Categoria: {Pedido2.Produto.Categoria}\n Valor total:{Pedido2.ValorTotal():C2}\n Impostos:{Pedido2.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome do Cliente: {Pedido3.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido3.Cliente.EnderecoCompleto()}\n Nome do Produto: {Pedido3.Produto.Nome}\n Categoria: {Pedido3.Produto.Categoria}\n Valor total:{Pedido3.ValorTotal():C2}\n Impostos:{Pedido3.TotalDeImpostos():C2}\n");

        }
    }
}
