using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Cliente
    {
        public int ID { get; }
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

        public Cliente(string primeiroNome, string sobrenome, string cpf, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
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
