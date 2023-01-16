using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Comex.Utils;

namespace Comex.Models
{
    public class Frete
    {
        public decimal Calcular(string cep)
        {
            Correios correios = new Correios();
            string setor = correios.ObterRegiaoPorCEP(cep);
            int valorPorRegiao = int.Parse(setor.Substring(7, 1));
           
            switch (valorPorRegiao)
            {
                case 0:
                case 1:
                case 2:
                    return 4;
                case 3: 
                case 8:
                    return 5;
                case 4:
                case 7:
                case 9:
                    return 6;
                case 5:
                case 6:
                    return 7;
                default: 
                    return 0;
            }

            
        }

        
            

       

     }
   
       

}



