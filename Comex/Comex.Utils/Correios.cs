using System;

namespace Comex.Utils
{
    public class Correios
    {
        public string Cep { get; set; }

        public Correios(string cep)
        {
            Cep = cep;
        }

        public char ObterRegiaoPorCEP()
        {
            return Cep.FirstOrDefault();
        }
    }
}
