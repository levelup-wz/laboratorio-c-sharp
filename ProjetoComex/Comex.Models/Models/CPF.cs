using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
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
            //cpfValidation = NewValidation(cpf);


            if (!cpfValidation)
            {
                Console.WriteLine("Cpf Inválido");
                //throw new ArgumentException("Informe um valor válido para o CPF");
            }

            if (cpfValidation)
            {
                Cpf = cpf;
            }
            
        }

        public string Formatar()
        {   
            if (cpfValidation)
            {
                var newCpf = Cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                return newCpf;
            }

            return "Cpf Inválido";
           
        }

        public bool Validation(string cpf)
        {
            var isNumeric = long.TryParse(cpf, out _);

            if (string.IsNullOrWhiteSpace(cpf) || !isNumeric || cpf.Length != 11)
            {   
                return false;
            }

            return true;
        }

        public bool NewValidation(string cpf)
        {
            Regex regex = new Regex("[0-9]{11}");
            var validate = regex.IsMatch(cpf);
            
            if (validate && cpf.Length == 11)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Cpf;
        }
    }
}
