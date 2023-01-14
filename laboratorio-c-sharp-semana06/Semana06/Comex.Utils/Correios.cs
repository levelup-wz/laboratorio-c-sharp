using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Utils
{
    public class Correios
    {
        public string ObterRegiaoPorCEP (string cep)
        {
            int regiao = int.Parse (cep.Substring(0,1));

            switch(regiao)
            {
                case 0:
                    return "Sede: São Paulo";

                case 1:
                    return "Sede: Santos";

                case 2:
                    return "Sede: Rio de Janeiro ";

                case 3:
                    return "Sede: Belo Horizonte";

                case 4:
                    return "Sede: Salvador";

                case 5:
                    return "Sede: Recife";

                case 6:
                    return "Sede: Fortaleza";

                case 7:
                    return "Sede Brasília";

                case 8:
                    return "Sede: Curitiba";

                case 9:
                    return "Sede: Porto Alegre";

                default:
                    return "O CEP informado é invalido, por favor digite um CEP válido";


            }
           
        }
    }
}
