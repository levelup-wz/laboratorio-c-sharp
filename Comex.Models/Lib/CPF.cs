using System.Text.RegularExpressions;

namespace Comex.Models.Lib
{
    public sealed class CPF
    {
        private readonly string _cpf;

        public CPF(string cpf)
        {

            _cpf = cpf ?? throw new ArgumentException("CPF informado é inválido");

            if (Regex.Match(_cpf, @"\D+").Success)
                throw new ArgumentException("CPF contém caracteres inválidos");
        }

        public string Formatar()
        {
            var match = Regex.Match(_cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})");
            return string.Format("{0}.{1}.{2}-{3}", match.Groups[1].Value
            , match.Groups[2].Value
            , match.Groups[3].Value
            , match.Groups[4].Value);
        }

        // escrever versão curta
        public override string ToString() => this._cpf;

    }
}
