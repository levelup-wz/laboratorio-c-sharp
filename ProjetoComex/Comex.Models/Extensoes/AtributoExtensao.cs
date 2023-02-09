using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Extensoes
{
    public static class AtributoExtensao
    {
        public static string ExtrairTamanho(this string atributo)
        {
            return atributo.Substring(9, 1);
        }

        public static string ExtrairCor(this string atributo)
        {

            return atributo.Substring(17);
        }
    }
}
