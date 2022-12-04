namespace Comex
{
  public class Cliente
  {
    public int Id { get; set; }
    public string PrimeiroNome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public Cliente(int id, string primeiroNome, string sobrenome, string cpf, string telefone, string rua, string numero, string complemento, string bairro, string cidade, string estado)
    {
      Id = id;
      PrimeiroNome = primeiroNome;
      Sobrenome = sobrenome;
      Cpf = cpf;
      Telefone = telefone;
      Rua = rua;
      Numero = numero;
      Complemento = complemento;
      Bairro = bairro;
      Cidade = cidade;
      Estado = estado;
    }

    public string ObterNomeCompleto()
    {
      return $"{PrimeiroNome} {Sobrenome}";
    }

    public string ObterEnderecoCompleto()
    {
      return $"{Rua}, {Numero} - {Complemento} - {Bairro} - {Cidade} - {Estado}";
    }
  }
}