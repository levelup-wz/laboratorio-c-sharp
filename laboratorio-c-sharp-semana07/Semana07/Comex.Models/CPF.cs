using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comex.Models
{
    public  class CPF
    {
        public String Cpf{ get; set; }

        public  CPF (String cpf)
        {
            Cpf = cpf;
        }

        public string Formatar()
        {
            bool CpfNum = Regex.IsMatch(Cpf, @"^\d+$");

            if (!CpfNum)
            {
                throw new ArgumentException("São permitidos apenas caracteres númericos");
            }
            if (string.IsNullOrEmpty(Cpf))
            {
                throw new ArgumentException("Digite o seu CPF");
            }
            if (Cpf.Length > 11)
            {
                throw new ArgumentException("O CPF deve conter 11 números");
            }
            if (Cpf.Length < 11)
            {
                throw new ArgumentException("O CPF deve conter 11 números");
            }
            return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");

        }

        public override string ToString()
        {
            return Cpf;
        }


    }
}
