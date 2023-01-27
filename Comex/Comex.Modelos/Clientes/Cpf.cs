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

    private string Formatar(string cpf)
    {
        return cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9,2);
    }

    public override string ToString()
    {
        return $"Cpf: {CPF}";
    }
}
