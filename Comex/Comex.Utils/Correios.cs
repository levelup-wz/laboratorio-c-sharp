using System;

namespace Comex.Utils
{
    public class Correios
    {
        public char ObterRegiaoPorCEP(string cep)
        {
            return cep.FirstOrDefault();
        }
    }
}
