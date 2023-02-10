using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Extensoes
{
    public static class AtributoExtensao
    {
        public static string ExtrairTamanho(this string atributos)
        {
            string[] atributosRoupa = atributos.Split(';');
            int indice = atributosRoupa[0].IndexOf("tamanho: ") + 9;

            return atributosRoupa[0].Substring(indice);
        }

        public static string ExtrairCor(this string atributos)
        {
            string[] atributosRoupa = atributos.Split(';');
            int indice = atributosRoupa[1].IndexOf("cor: ") + 5;

            return atributosRoupa[1].Substring(indice);
        }
    }
}
