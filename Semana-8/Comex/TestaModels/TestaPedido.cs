using Comex.Models;

namespace Comex.TestaModels
{
    public class TestaPedido
    {
        static Cliente cliente1 = new Cliente("Saulo", "Alves Magalhães", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        static Cliente cliente2 = new Cliente("André", "Sousa", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");
        static Cliente cliente3 = new Cliente("Davi", "Kennedy", new Cpf("99999999999"), "99999999999", "Rua Luva De Pedreiro", "100", "Casa", "Ibotirama", "BA");

        static Pedido Pedido1 = new Pedido(cliente1, new ItemsDoPedido(new Produto("Notebook Samsung", 3523.00, 10, "Informática"), 10));
        static Pedido Pedido2 = new Pedido(cliente2, new ItemsDoPedido(new Produto("Clean Architecture", 102.90, 10, "Informática"), 10));
        static Pedido Pedido3 = new Pedido(cliente3, new ItemsDoPedido(new Produto("Monitor Dell 27", 1889.00, 10, "Informática"), 10));
        
    public static void Main()
        {
            Pedido1.Items.Add(new ItemsDoPedido(new Produto("Iphone 14", 5500.00, 10, "Informática"), 10));
            Pedido1.RemoverItemDoPedido("Iphone 14");
            Pedido1.EditarQuantidade("Notebook Samsung", 5);

            string produtos1 = "";
            string categoria1 = "";
            foreach(var item in Pedido1.Items)
            {
                produtos1 += item.Produto.Nome + ", ";
                categoria1 = item.Produto.Categoria;
            };
            var produtos2 = "";
            string categoria2 = "";
            foreach (var item in Pedido2.Items)
            {
                produtos2 += item.Produto.Nome;
                categoria2 = item.Produto.Categoria;
            };
            var produtos3 = "";
            string categoria3 = "";
            foreach (var item in Pedido3.Items)
            {
                produtos3 += item.Produto.Nome;
                categoria3 = item.Produto.Categoria;
            };

            Console.WriteLine($" Nome do Cliente: {Pedido1.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido1.Cliente.EnderecoCompleto()}\n Nome do Produto: {produtos1}\n Categoria: {categoria1}\n Valor total:{Pedido1.ValorTotal():C2}\n Impostos:{Pedido1.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome do Cliente: {Pedido2.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido2.Cliente.EnderecoCompleto()}\n Nome do Produto: {produtos2}\n Categoria: {categoria2}\n Valor total:{Pedido2.ValorTotal():C2}\n Impostos:{Pedido2.TotalDeImpostos():C2}\n");
            Console.WriteLine($" Nome do Cliente: {Pedido3.Cliente.NomeCompleto()}\n Endereço do Cliente: {Pedido3.Cliente.EnderecoCompleto()}\n Nome do Produto: {produtos3}\n Categoria: {categoria3}\n Valor total:{Pedido3.ValorTotal():C2}\n Impostos:{Pedido3.TotalDeImpostos():C2}\n");
        }
    }
}
