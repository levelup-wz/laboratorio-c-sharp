using Comex.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Test
{
    public class TestProductExempt
    {
        List<ProductExempt> listProducts = new List<ProductExempt>();

        public void ToList()
        {
            Categories categoryProd1 = new Categories("Saúde", "Ativa");
            ProductExempt exemptProduct1 = new ProductExempt("Vacina", "covid", 250.00, 1000, categoryProd1);

            Categories categoryProd2 = new Categories("Livros", "Ativa");
            ProductExempt exemptProduct2 = new ProductExempt("Use a Cabeça: Java", "114 pages", 112.90, 5, categoryProd2);

            Categories categoryProd3 = new Categories("Informática", "Ativa");
            ProductExempt exemptProduct3 = new ProductExempt("Macbook Pro", "20pol", 20000.00, 11, categoryProd3);

            listProducts.Add(exemptProduct1);
            listProducts.Add(exemptProduct2);
            listProducts.Add(exemptProduct3);

            Console.WriteLine("4) LISTANDO PRODUTOS ISENTOS...");
            foreach (ProductExempt value in listProducts)
            {
                Console.WriteLine($"Nome: {value.Name}| Descrição: {value.Description} | Preço: {value.UnitPrice} | Estoque: {value.StockQuantity} | Categoria: {value.Category.Name}");
                Console.WriteLine("Valor total em estoque: " + value.TotalAmountStock());
                Console.WriteLine("Imposto: " + value.CalculateTax());
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }



        }
    }
}

//rie uma classe main chamada TestaProdutoIsento;
//no método main:
//crie os produtos abaixo:
//id 1, nome Vacina, preço unitário 250.00, quantidade em estoque 1000, categoria Saúde (ISENTO);
//id 2, nome Use a Cabeça: Java, preço unitário 112.90, quantidade em estoque 5, categoria Livros (ISENTO)
//id 3, nome Macbook Pro, preço unitário 20000.00, 
//    quantidade em estoque 11, categoria Informática
//    valor total em estoque e o imposto (invente uma formatação bacana para a saída);
//Verifique se os impostos aparecem corretamente de acordo com o produto.