using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Comex.Modelos.Clientes
{
    public class Cpf
    {
        public string CPF { get; }
        public Cpf(string cpf)
        {
            CPF = cpf;
        }

        public string Formatar()
        {
            return CPF.Substring(0, 3) + "." + CPF.Substring(3, 3) + "." + CPF.Substring(6, 3) + "-" + CPF.Substring(9,2);
        }

        public override string ToString()
        {
            return $"Cpf: {CPF}";
        }
    }
}
