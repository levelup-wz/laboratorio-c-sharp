using Comex.Entity;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Test
{
    public class TestCheckOutStock
    {
        
        List<Stock> listProductsStock = new List<Stock>();
        public void ToList()
        {
            Categories categoryProd1 = new Categories("Saúde", "Ativa");
            ProductExempt exemptProduct1 = new ProductExempt("Vacina", "covid", 250.00, 500, categoryProd1);

            Stock stock1 = new Stock();
            
            Console.WriteLine("SAÍDA DO ESTOQUE - Registrando entrada");
            stock1.CheckIn(exemptProduct1);
            Console.WriteLine($"Capacidade: {stock1.Capacity}\n" +
            $"Ocupação: {stock1.QuantProductsStored}\n" +
            $"Montante: {stock1.Amount}\n");

            
            stock1.CheckOut(exemptProduct1);
            

            listProductsStock.Add(stock1);

            Console.WriteLine("6) LISTANDO SAÍDA NO ESTOQUE...");

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
