using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class EstoqueException : Exception
    {
        public EstoqueException(string mensagem) :base(mensagem) 
        {
            Console.WriteLine(mensagem);
        }
        
    }
}
