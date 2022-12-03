using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Cliente
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public string ObterNomeCompleto()
        {
            return PrimeiroNome + Sobrenome;
        }

        public string ObterEndereco()
        {
            return $"Endereço:\nRua: {Rua}\nNº {Numero}\nComplemento: {Complemento}\nBairro: {Bairro}\nCidade: {Cidade}\nEstado: {Estado}";
        }
        public Cliente(string primeiroNome, string sobrenome, int cpf, int telefone, string rua, int numero, string complemento, string bairro, string cidade, string estado)
        {
            TotalClientes += 1;

            Id = TotalClientes;
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

        public static int TotalClientes { get; set; }
    }
}
