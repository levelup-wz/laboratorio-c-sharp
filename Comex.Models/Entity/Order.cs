using Comex.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entity
{
    public class Order
    {
        private static int _id = 0;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CPF { get; set; }
        public Products Product { get; set; }
        public int SoldAmount { get; set; }
        public Client Client { get; set; }

        public Order(DateTime date, string cpf, Products product, int soldAmount, Client client)
        {
            Id = _id++;
            Date = date;
            CPF = cpf;
            Product = product;
            SoldAmount = soldAmount;
            Client = client;
        }

        public double TotalPrice()
        {

            return Math.Round(SoldAmount * Product.UnitPrice, 2);
        }

        public double TotalTax()
        {

            return Math.Round(SoldAmount * Product.CalculateTax(), 2);
        }


    }
}



