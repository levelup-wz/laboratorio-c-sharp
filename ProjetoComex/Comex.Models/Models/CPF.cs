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

        private bool cpfValidation { get; set; }
        public CPF(string cpf)
        {
            cpfValidation =  Validation(cpf);
            
            if (!cpfValidation)
            {
                throw new ArgumentException("Informe um valor válido para o CPF");
            }

            Cpf = cpf;
        }

        public string Formatar()
        {
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
