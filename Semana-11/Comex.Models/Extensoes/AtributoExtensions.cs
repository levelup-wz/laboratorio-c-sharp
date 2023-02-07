using System.Text.RegularExpressions;

namespace Comex.Models.Extensoes;

public static class AtributoExtensions
{
    public static string ExtrairTamanho(this string input)
    {
        input.ToLower();
        var match = Regex.Match(input, @"tamanho: (\w+)");
        return match.Success ? match.Groups[1].Value : null;
    }

    public static string ExtrairCor( this string input)
    {
        input.ToLower();
        var match = Regex.Match(input, @"cor: (\w+)");
        return match.Success ? match.Groups[1].Value : null;
    }
}
