using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Extensoes
{
    public static class AtributoExtensao
    {
        public static string ExtrairTamanho (this string tamanho)
        {
            return tamanho.Substring(9, 1);

        }

        public static string ExtrairCor (this string cor)
        {
            return cor.Substring(17);

        }
    }
}
