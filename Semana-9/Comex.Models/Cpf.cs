using System.Text.RegularExpressions;

namespace Comex.Models
{
    public class Cpf
    {
        private readonly string _cpfSemFormatacao;

        public Cpf(string cpf)
        {
            ValidarCpf(cpf);
            _cpfSemFormatacao = cpf;
        }

        public void ValidarCpf(string cpf)
        {
            bool cpfIsNumeric = Regex.IsMatch(cpf, @"^\d+$");

            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("Cpf deve ser informado");
            }
            if (!cpfIsNumeric)
            {
                throw new Exception("Cpf inválido");
            }
            if (cpf.Length != 11)
            {
                throw new Exception("Cpf inválido");
            }
        }
        public string Formatar() 
        {
            return Convert.ToUInt64(_cpfSemFormatacao).ToString(@"000\.000\.000\-00");
        }

        public override string ToString()
        {
            return _cpfSemFormatacao;
        }
    }
}
