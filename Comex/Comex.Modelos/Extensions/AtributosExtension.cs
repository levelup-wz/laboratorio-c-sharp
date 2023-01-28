using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Extensions;

internal static class AtributosExtension
{
    internal static string ExtrairTamanho(this Vestuario vestuario, string atributos)
    {
        string param = "tamanho:";
        int index = atributos.IndexOf(param);
        string resultado = atributos.Substring(index + param.Length);

        if (resultado.IndexOf(';') == -1)
        {
            return resultado;
        }

        return resultado.Remove(resultado.IndexOf(';'));
    }

    internal static string ExtrairCor(this Vestuario vestuario, string atributos)
    {
        string param = "cor:";
        int index = atributos.IndexOf(param);
        string resultado = atributos.Substring(index + param.Length);

        if (resultado.IndexOf(';') == -1)
        {
            return resultado;
        }

        return resultado.Remove(resultado.IndexOf(';'));
    }
}
