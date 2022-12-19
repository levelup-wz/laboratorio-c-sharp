using Comex.Entity;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Test
{
    public class TestCheckInStock
    {
        List<Products> listProducts = new List<Products>();
        List<Stock> listProductsStock = new List<Stock>();

        public void ToList()
        {
            Categories categoryProd1 = new Categories("Saúde", "Ativa");
            ProductExempt exemptProduct1 = new ProductExempt("Vacina", "covid", 250.00, 500, categoryProd1);

            Categories categoryProd2 = new Categories("Livros", "Ativa");
            ProductExempt exemptProduct2 = new ProductExempt("Use a Cabeça: Java", "114 pages", 112.90, 5, categoryProd2);

            Categories categoryProd3 = new Categories("Informática", "Ativa");
            Products exemptProduct3 = new Products("Macbook Pro", "20pol", 20000.00, 15, categoryProd3);

            listProducts.Add(exemptProduct1);
            listProducts.Add(exemptProduct2);
            listProducts.Add(exemptProduct3);


            Stock stock1= new Stock();
            stock1.CheckIn(exemptProduct1);
            Stock stock2 = new Stock();
            stock2.CheckIn(exemptProduct2);
            Stock stock3 = new Stock();
            stock3.CheckIn(exemptProduct3);

            listProductsStock.Add(stock1);
            listProductsStock.Add(stock2);
            listProductsStock.Add(stock3);
            

            Console.WriteLine("5) LISTANDO ENTRADA NO ESTOQUE...");            

            foreach (Stock value in listProductsStock)

            {                               
                                
                Console.WriteLine($"Capacidade do estoque: {value.Capacity}");
                Console.WriteLine($"Ocupação do estoque: {value.QuantProductsStored}");
                Console.WriteLine($"Montante do estoque: {value.Amount}");
                Console.WriteLine("-------------------------------------------------------------------------------------");

            }

        }
    }
}
