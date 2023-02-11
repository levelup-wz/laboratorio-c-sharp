using System;

namespace Comex.Modelos.Clientes;

public class Cliente
{
    public Cliente(string nome, string sobrenome, Cpf cpf, string telefone, string rua, string numero, string cidade, string estado)
    {
        Id = Quantidade++;
        Nome = nome;
        Sobrenome = sobrenome;
        Cpf = cpf;
        Telefone = telefone;
        Rua = rua;
        Numero = numero;
        Cidade = cidade;
        Estado = estado;
    }

    public static int Quantidade { get; private set; }
    public int Id { get; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Cpf Cpf { get; }
    public string Telefone { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string NomeCompleto => Nome + " " + Sobrenome;
    public string EnderecoCompleto => Rua + " " + Numero + " " + Cidade + " " + Estado;
}
