using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entity
{
    public class ProductExempt : Products
    {
        public ProductExempt(string name, string description, double unitPrice, int stockQuantity, Categories category) : base(name, description, unitPrice, stockQuantity, category)
        {           
            
        }
        
        public override double CalculateTax()
        {
            return 0;

        }
    }
}
