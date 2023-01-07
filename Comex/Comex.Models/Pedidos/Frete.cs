using System;
using Comex.Utils;

namespace Comex.Modelos.Pedidos
{
    public class Frete
    {
        public Correios Correios { get; set; }

        public Frete(string cep)
        {
            Correios = new Correios(cep);
        }

        /// <summary>
        /// Retorna o preço do frete do pedido
        /// </summary>
        /// <param name="cep"> Cep da região </param>
        /// <returns></returns>
        public decimal Calcular()
        {
            switch (Correios.ObterRegiaoPorCEP())
            {
                case '0' or '1' or '2':
                    return 4.00M;

                case '3' or '8':
                    return 5.00M;

                case '4' or '7' or '9':
                    return 6.00M;

                case '5' or '6':
                    return 7.00M;

                default: return 0.00M;
            }
        }
    }
}
