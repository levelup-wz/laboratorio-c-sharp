using System.Text.RegularExpressions;

namespace Comex.Models
{
    public class Cpf
    {
        public string CpfSemFormatacao { get; set; }

        public Cpf(string cpf)
        {
            CpfSemFormatacao = cpf;
        }

        public string Formatar() 
        {
            bool cpfIsNumeric = Regex.IsMatch(CpfSemFormatacao, @"^\d+$");

            if (string.IsNullOrWhiteSpace(CpfSemFormatacao))
            {
                return "Cpf deve ser informado";
            }
            if (!cpfIsNumeric)
            {
                return "Cpf inválido";
            }
            if (CpfSemFormatacao.Length != 11)
            {
                return "Cpf inválido";
            }

            return Convert.ToUInt64(CpfSemFormatacao).ToString(@"000\.000\.000\-00");

        }

        public override string ToString()
        {
            return CpfSemFormatacao;
        }

    }
}
