using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Cliente
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string NumeroDoEndereco { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public Cliente(string primeiroNome, string sobrenome, string cpf, string telefone, string rua, string numeroDoEndereco, string complemento, string cidade, string estado )
        {
            Id = ++_id;
            PrimeiroNome = primeiroNome;
            Sobrenome= sobrenome;
            Cpf= cpf;
            Telefone= telefone;
            Rua= rua;
            NumeroDoEndereco = numeroDoEndereco;
            Complemento= complemento;
            Cidade= cidade;
            Estado= estado;
        }

        public string NomeCompleto()
        {
            return $"{PrimeiroNome} {Sobrenome}"; 
        }

        public string EnderecoCompleto()
        {
            return $" {Rua}, {NumeroDoEndereco}, {Complemento}, {Cidade} - {Estado}";
        }
    }
}
