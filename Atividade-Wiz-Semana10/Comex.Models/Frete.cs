using Comex.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Frete
    {
        public decimal Calcular(string cep)
        {
            var regiao = Correios.ObterRegiaoPorCEP(cep);
            decimal valor = 0;

            if (regiao.Numero == '0' || regiao.Numero == '1' || regiao.Numero == '2')
            {
                valor = 4.00M;
            }
            if (regiao.Numero == '3' || regiao.Numero == '8')
            {
                valor = 5.00M;
            }
            if (regiao.Numero == '4' || regiao.Numero == '7' || regiao.Numero == '9')
            {
                valor = 6.00M;
            }
            if (regiao.Numero == '5' || regiao.Numero == '6')
            {
                valor = 7.00M;
            }
            return valor;
        }
    }
}
