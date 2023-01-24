using System.Text.RegularExpressions;

namespace Comex.Models.Extensoes
{
    public static class AtributoExtensoes
    {
        public static string ExtrairTamanho(this string atributos)
        {
            var tamanho = Regex.Match(atributos, @"(?<=tamanho:\s?)[a-z]", RegexOptions.IgnoreCase);
            return tamanho.Value.Trim();
        }

        public static string ExtrairCor(this string atributos)
        {
            var cor = Regex.Match(atributos, @"(?<=cor:\s?)\w+", RegexOptions.IgnoreCase);
            return cor.Value.Trim();
        }
    }
}
