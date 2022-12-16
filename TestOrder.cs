using Comex.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    class TestOrder
    {
        List<Order> listOrders = new List<Order>();

        public void ToList()
        {
            Categories categoryProd1 = new Categories("Informática", "Ativa");
            Products product1 = new Products("Notebook Samsung", "Notebook Corei7", 3523.00, 5, categoryProd1);                       
            Order order1 = new Order(DateTime.Today, "111.222.333.444-55", product1, 4);

            Categories categoryProd2 = new Categories("Livros", "Ativa");
            Products product2 = new Products("Clean Architecture", "114 pages", 102.90, 4, categoryProd2);
            Order order2 = new Order(DateTime.Today, "222.333.444-55", product2, 3);

            Categories categoryProd3 = new Categories("Informática", "Ativa");
            Products product3 = new Products("Monitor Dell 27", "20pol", 1889.00, 3, categoryProd3);
            Order order3 = new Order(DateTime.Today, "333.444.555-66", product3, 2);

            listOrders.Add(order1);
            listOrders.Add(order2);
            listOrders.Add(order3);

            Console.WriteLine("3) LISTANDO PEDIDOS...");
            foreach (Order value in listOrders)
            {
                Console.WriteLine($"ID do Pedido: {value.Id}| Produto: {value.Product.Name} | Preço: {value.Product.UnitPrice} | Quantidade Vendida: {value.SoldAmount} | Categoria: {value.Product.Category.Name}");
                Console.WriteLine("Valor total do pedido: R$ " + value.TotalPrice());
                Console.WriteLine("Imposto Total: R$ " + value.TotalTax());
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }

        }
    }
}