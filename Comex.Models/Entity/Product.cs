using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entity
{
    public class Products
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int StockQuantity { get; set; }
        public Categories Category { get; set; }


        public Products(string name, string description, double unitPrice, int stockQuantity, Categories category)
        {
            Id = _id++;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            StockQuantity = stockQuantity;
            Category = category;

        }

        public virtual double TotalAmountStock()
        {

            return StockQuantity * UnitPrice;

        }

        public virtual double CalculateTax()
        {
            return UnitPrice * 0.4;

        }

    }






}



//Crie uma classe Produto para representar os produtos vendidos no comércio eletrônico.

//Atributos
//id: númerico
//nome: nome que descreve o produto;
//descrição: informações sobre as características do produto;
//preço Unitário: preço cobrado pelo produto;
//quantidade em estoque: quantos itens desse produto estão disponíveis;
//categoria: a categoria à qual este produto está vinculado.
//Métodos
//Propriedades get e set para todos os atributos;
//Calcula valor total em estoque: multiplica a quantidade em estoque pelo preço unitário;
//calcula imposto: 40 % do preço unitário.