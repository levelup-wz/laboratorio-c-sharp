using System;
using Comex.Utils;

namespace Comex.Modelos.Pedidos
{
    public class Frete
    {
        public static decimal Calcular(string cep)
        {
            switch (Correios.ObterRegiaoPorCEP(cep))
            {
                case '0' or '1' or '2':
                    return 4.00M;

                case '3' or '8':
                    return 5.00M;

                case '4' or '7' or '9':
                    return 6.00M;

                case '5' or '6':
                    return 7.00M;

                default: return 8.00M;
            }
        }
    }
}
