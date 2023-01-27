using System;

namespace Comex.Modelos.Clientes;

public class Cpf
{
    public string CPF { get; private set; }
    public Cpf(string cpf)
    {
        if (cpf.Length != 11)
        {
            throw new ArgumentException("Formato de cpf inválido!", nameof(cpf));
        }

        CPF = cpf;
        Formatar();
    }

    private void Formatar()
    {
        CPF = CPF.Substring(0, 3) + "." + CPF.Substring(3, 3) + "." + CPF.Substring(6, 3) + "-" + CPF.Substring(9,2);
    }

    public override string ToString()
    {
        return $"Cpf: {CPF}";
    }
}
