using Comex.Utils;

namespace Comex.Models
{
    public class Frete
    {
        public decimal Calcular(string cep)
        {
            var regiao = int.Parse(Correios.ObterRegiaoPorCEP(cep));
            if(regiao == 0 || regiao == 1 || regiao == 2)
            {
                return 4.00M;
            }
            else if(regiao == 3 || regiao == 8)
            {
                return 5.00M;
            }
            else if(regiao == 4 || regiao == 7 || regiao == 9)
            {
                return 6.00M;
            }
            else
            {
                return 7.00M;
            }
        }
    }
}
