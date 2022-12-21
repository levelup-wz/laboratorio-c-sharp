using Comex.Exceptions;
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
            if (product.StockQuantity > Capacity)
            {
                throw new LimitCapacityStockException("Capacidade de estoque ultrapassou o limite.");
            }
            Capacity -= product.StockQuantity;
            QuantProductsStored += product.StockQuantity;
            Amount += (decimal)product.TotalAmountStock();            

        }

        public void CheckOut(Products product)
        {
            if (QuantProductsStored <= 0)
            {
                throw new LimitCapacityStockException("Não há produtos no estoque.");
            }
            Capacity += product.StockQuantity;
            QuantProductsStored -= product.StockQuantity;
            Amount -= (decimal)product.TotalAmountStock();

        }

    }
}
