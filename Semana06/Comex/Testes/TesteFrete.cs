using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comex.Models;
using Comex.Utils;

namespace Comex.Testes
{
    public class TesteFrete
    {

          static Frete frete0 = new Frete();

          public  TesteFrete()
          {
              Console.WriteLine($"{frete0.Calcular("75740000")}");
          }
    }   

}


 

