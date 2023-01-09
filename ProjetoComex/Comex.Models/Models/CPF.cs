using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Models
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

            var cpfValidation = Validation(Cpf);

            if (!cpfValidation)
            {
                throw new ArgumentException("Informe um valor válido para o CPF");
            }

            var newCpf = Cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            return newCpf;
        }

        public bool Validation(string cpf)
        {
            var isNumeric = long.TryParse(cpf, out _);

            if (!isNumeric)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {   
                return false;
            }

            if (cpf.Length != 11)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return Cpf;
        }
    }
}
