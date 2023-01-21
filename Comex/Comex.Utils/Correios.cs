using System;

namespace Comex.Utils
{
    public class Correios
    {
        public static char ObterRegiaoPorCEP(string cep)
        {
            return cep.FirstOrDefault();
        }
    }
}
