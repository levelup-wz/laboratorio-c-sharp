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
        public int _id { get; }
        public string _nome { get; }
        public string _sobreNome { get; }
        public string _cpf { get; }
        public string _telefone { get; }
        public string _rua { get; }
        public string _numeroEndereco { get; }
        public string _complemento { get; }
        public string _bairro { get; }
        public string _cidade { get; }
        public string _estado { get; }

        public Cliente(string nome, string sobreNome, string cpf, string telefone, string rua,
            string numero, string complemento, string bairro, string cidade, string estado)
        {
            _nome = nome;
            _sobreNome = sobreNome;
            _cpf = cpf;
            _telefone = telefone;
            _rua = rua;
            _numeroEndereco = numero;
            _complemento = complemento;
            _bairro = bairro;
            _cidade = cidade;
            _estado = estado;
            _id = Cliente.numCliente;
            Cliente.numCliente++;
        }
        public string NomeCompleto()
        {
            return $"{_nome} {_sobreNome}";
        }

        public string EnderecoCompleto()
        {
            return ($"Rua: {_rua}, nº {_numeroEndereco}, complemento: {_complemento}," +
                $" bairro: {_bairro}, cidade: {_cidade}, estado: {_estado}");
        }

        public void ListarCliente()
        {
            Console.WriteLine($"***** Código do Cliente nº {_id} *****");
            Console.WriteLine($"Nome: {NomeCompleto()}");
            Console.WriteLine($"Endereço: {EnderecoCompleto()}");
        }
    }
}
