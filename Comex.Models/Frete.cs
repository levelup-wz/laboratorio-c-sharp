
using Comex.Utils;


namespace Comex.Models
{
    public class Frete
    {
        public double Calcular(string cep)
        {
            var cepHelper = new Correios();
            var regiao = cepHelper.ObterRegiaoPorCEP(cep);

            switch (regiao)
            {
                case Regiao.Santos:
                    return 10.00;
                case Regiao.BH:
                    return 12.50;
                default:
                    throw new Exception("Não foi possível achar o cep");
            }


        }
    }
}
