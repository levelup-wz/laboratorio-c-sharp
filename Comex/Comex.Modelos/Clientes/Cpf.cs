using System;

namespace Comex.Modelos.Clientes;

public class Cpf
{
    public string CPF { get; }

    public Cpf(string cpf)
    {
        if (cpf.Length != 11)
        {
            throw new ArgumentException("Formato de cpf inválido!", nameof(cpf));
        }

        CPF = Formatar(cpf);
    }

    private static string Formatar(string cpf)
    {
        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
    }
}
