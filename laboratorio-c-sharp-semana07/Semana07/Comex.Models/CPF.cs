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
        private readonly string Cpf;

        public CPF(string cpf)
        {
            Cpf = cpf;
        }


        public string Formatar()
        {
            bool CpfNum = Regex.IsMatch(Cpf, @"^\d+$");

            if (!CpfNum)
            {
                return "CPF Invalido, são permitidos apenas caracteres númericos.";
            }
            if (string.IsNullOrEmpty(Cpf))
            {
                return "CPF Invalido, digite o seu CPF.";
            }
            if (Cpf.Length > 11)
            {
                return "CPF Invalido, o CPF deve conter 11 números.";
            }
            if (Cpf.Length < 11)
            {
                return "CPF Invalido, o CPF deve conter 11 números.";
            }
            return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
            // return Regex.Replace(Cpf, @"(.{3})(.{3})(.{3})(.{2})", @"$1.$2.$3-$4");
        }   

        public override string ToString()
        {
            return Cpf;
        }
    }

       


    
}
