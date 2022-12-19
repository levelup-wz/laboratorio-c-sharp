using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Cliente
    {
        public static int numCliente = 1;
        public int Id { get; }
        public string Nome { get; }
        public string SobreNome { get; }
        public string Cpf { get; }
        public string Telefone { get; }
        public string Rua { get; }
        public string NumeroEndereco { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }

        public Cliente(string nome, string sobreNome, string cpf, string telefone, string rua,
            string numero, string complemento, string bairro, string cidade, string estado)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Cpf = cpf;
            Telefone = telefone;
            Rua = rua;
            NumeroEndereco = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Id = Cliente.numCliente;
            Cliente.numCliente++;
        }
        public string NomeCompleto()
        {
            return $"{Nome} {SobreNome}";
        }

        public string EnderecoCompleto()
        {
            return ($"Rua: {Rua}, nº {NumeroEndereco}, complemento: {Complemento},\n" +
                $"bairro: {Bairro}, cidade: {Cidade}, estado: {Estado}");
        }

        public string ListarCliente()
        {
            return ($"***** Código do Cliente nº {Id} *****\n" +
                $"Nome: {NomeCompleto()}\n" +
                $"Endereço: {EnderecoCompleto()}");
        }
    }
}
