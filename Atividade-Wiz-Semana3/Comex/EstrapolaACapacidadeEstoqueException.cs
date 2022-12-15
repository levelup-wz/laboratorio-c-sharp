using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class EstrapolaACapacidadeEstoqueException : Exception
    {
        public EstrapolaACapacidadeEstoqueException() { }
        public EstrapolaACapacidadeEstoqueException(string message) : base(message) { }
        public EstrapolaACapacidadeEstoqueException(string message, Exception innerException) : base(message, innerException) { }
    }
}
