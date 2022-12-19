using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entity
{
    public class Stock
    {
        public int Capacity { get; set; } = 1000;
        public int QuantProductsStored { get; set; }
        public decimal Amount { get; set; }
        

        public void CheckIn(Products product)
        {
            Capacity -= product.StockQuantity;
            QuantProductsStored += product.StockQuantity;
            Amount += (decimal)product.TotalAmountStock();            

        }

        public void CheckOut(Products product)
        {
            Capacity += product.StockQuantity;
            QuantProductsStored -= product.StockQuantity;
            Amount -= (decimal)product.TotalAmountStock();

        }

    }
}
