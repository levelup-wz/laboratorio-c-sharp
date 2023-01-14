using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class CPF
    {
        public string Cpf { get; private set; }
        public CPF(string cpf)
        {
            Cpf = cpf;
        }

        public string Formatar()
        {
            return $"{Cpf.Substring(0, 3)}.{Cpf.Substring(3, 3)}.{Cpf.Substring(6, 3)}-{Cpf.Substring(9, 2)}";
        }

        public override string ToString()
        {
            return Cpf;
        }
    }
}
