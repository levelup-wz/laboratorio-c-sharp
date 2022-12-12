using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Exceptions
{
    public class CustonException : Exception
    {
        public CustonException(string mensagem) : base(mensagem)
        {
            
        }
    }
}
