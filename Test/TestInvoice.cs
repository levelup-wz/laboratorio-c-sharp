using Comex.Entity;
using Comex.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Test
{
    public class TestInvoice    {
        
        public void ToList()
        {
            Categories categoryProd1 = new Categories("Informática", "Ativa");
            Products product1 = new Products("Notebook Samsung", "Notebook Corei7", 3523.00, 3, categoryProd1);
            Client tamara = new Client("Tamara", "Costa");
            Order order1 = new Order(DateTime.Today, "111.222.333.444-55", product1, 4, tamara);
            Invoice invoice = new Invoice(order1);

            Console.WriteLine(" LISTANDO NOTAS FISCAIS...");
            Console.WriteLine(invoice.GetInvoice());
            



        }
    }
}
