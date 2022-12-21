using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Cliente
    {
        private static int _id = 1;
        public int Id { get; }
        public string PrimeiroNome { get; }
        public string Sobrenome { get; }
        public string Cpf { get; }
        public string Telefone { get; }
        public string Rua { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }

        public Cliente(string primeiroNome, string sobrenome, string cpf, string telefone, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            Id = _id++;
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

        public int DefineId()
        {
            return Id;
        }

        public string NomeCompleto()
        {
            string nomeCompleto = $"{PrimeiroNome} {Sobrenome}";
            return nomeCompleto;
        }

        public string EnderecoCompleto()
        {
            string enderecoCompleto = $"{Rua} {Numero} {Complemento} {Bairro} {Cidade} {Estado}";
            return enderecoCompleto;
        }
    }
}
