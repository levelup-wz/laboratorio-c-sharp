using System;
using Comex.Utils;

namespace Comex.Modelos.Pedidos
{
    public class Frete
    {
        /// <summary>
        /// Retorna o preço do frete do pedido
        /// </summary>
        /// <param name="cep"> Cep da região </param>
        /// <returns></returns>
        public decimal Calcular(string cep)
        {
            Correios correios = new Correios();
            switch (correios.ObterRegiaoPorCEP(cep))
            {
                case '0' or '1' or '2':
                    return 4;

                case '3' or '8':
                    return 5;

                case '4' or '7' or '9':
                    return 6;

                case '5' or '6':
                    return 7;
            }
        }
    }
}
