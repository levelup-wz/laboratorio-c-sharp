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

        CPF = cpf;
    }

    public string Formatar()
    {
        string formatado = CPF.Substring(0, 3) + "." + CPF.Substring(3, 3) + "." + CPF.Substring(6, 3) + "-" + CPF.Substring(9,2);
        return formatado;
    }

    public override string ToString()
    {
        return $"Cpf: {CPF}";
    }
}
