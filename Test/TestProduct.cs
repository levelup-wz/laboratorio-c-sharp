using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Entity;

namespace Comex.Test
{
    class TestProduct
    {

        List<Products> listProducts = new List<Products>();

        public void ToList()
        {
            Categories categoryProd1 = new Categories("Informática", "Ativa");
            Products product1 = new Products("Notebook Samsung", "Notebook Corei7", 3523.00, 1, categoryProd1);

            Categories categoryProd2 = new Categories("Livros", "Ativa");
            Products product2 = new Products("Clean Architecture", "114 pages", 102.90, 2, categoryProd2);

            Categories categoryProd3 = new Categories("Informática", "Ativa");
            Products product3 = new Products("Monitor Dell 27", "20pol", 1889.00, 3, categoryProd3);

            listProducts.Add(product1);
            listProducts.Add(product2);
            listProducts.Add(product3);

            Console.WriteLine("2) LISTANDO PRODUTOS...");
            foreach (Products value in listProducts)
            {
                Console.WriteLine($"Nome: {value.Name}| Descrição: {value.Description} | Preço: {value.UnitPrice} | Estoque: {value.StockQuantity} | Categoria: {value.Category.Name}");
                Console.WriteLine("Valor total em estoque: " + value.TotalAmountStock());
                Console.WriteLine("Imposto: " + value.CalculateTax());
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }



        }










    }
}
