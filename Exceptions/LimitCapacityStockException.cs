using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class LimitCapacityStockException : Exception
    {
        public LimitCapacityStockException() { }
        public LimitCapacityStockException(string message) : base(message) { }
        public LimitCapacityStockException(string message, Exception innerException) : base(message, innerException) { }

    }
}
