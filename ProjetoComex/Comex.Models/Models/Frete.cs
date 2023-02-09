using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Utils;


namespace Comex.Models.Models
{
    public class Frete
    {
        public decimal Calcular(string cep)
        {
            var region = Correios.ObterRegiaoPorCEP(cep);
            decimal result = 0.00M;

            if (region == "0" || region == "1" || region == "2") result = 4.00M;
            if (region == "3" || region == "8") result = 5.00M;
            if (region == "4" || region == "7" || region == "9") result = 6.00M;
            if (region == "5" || region == "6") result = 7.00M;

            return result;
        }
        
    }
}
