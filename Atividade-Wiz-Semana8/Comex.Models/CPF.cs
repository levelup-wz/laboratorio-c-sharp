using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class CPF
    {
        public string Cpf { get; set; }

        public CPF(string cpf) 
        {
            Cpf = cpf;
        }

        public string Formatar()
        {
            bool numeroCpf = Regex.IsMatch(Cpf, @"^\d+$");

            if (Cpf.Length > 11)
            {
                throw new ArgumentException("Você excedeu a quantida valida de caracteres");
            }
            if (string.IsNullOrEmpty(Cpf))
            {
                throw new ArgumentException("Você não colocou um CPF");
            }
            if (Cpf.Length < 11)
            {
                throw new ArgumentException("Você não colocou uma quantidade valida de caracteres");
            }
            if (!numeroCpf)
            {
                throw new ArgumentException("Caracteres não permitidos");
            }

            return Regex.Replace(Cpf, @"(.{3})(.{3})(.{3})(.{2})", @"$1.$2.$3-$4");

            //return Cpf.Substring(0, 3) + "." + Cpf.Substring(3, 3) + "." + Cpf.Substring(6, 3) + "-" + Cpf.Substring(9, 2);
        }

        public override string ToString()
        {
            return Cpf;
        }
    }
}
