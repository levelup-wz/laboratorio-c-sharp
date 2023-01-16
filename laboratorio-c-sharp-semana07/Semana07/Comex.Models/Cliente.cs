using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public static int ContId = 0;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string   Rua { get; set; }
        public string Numero { get; set; }
        public string   Complemento { get; set;}
        public string Bairro { get; set;}
        public string Cidade { get; set;}
        public string Estado { get; set; }
        public Cliente ClienteClasse { get; set; } // tipo cliente

        public Cliente( string nome, string sobrenome, string cpf, string celular, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            Id = ++ContId;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Celular = celular;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            //this.cliente = cliente;
        }

        public string RetornaCliente()
        {
            return
               $"Número do cliente: {Id}\n" +
               $"Nome Completo: {Nome} {Sobrenome} \n" +
               $"CPF: {Cpf}\n" +
               $"Celular: {Celular}\n" +
               $"Endereço: {Rua}, número: {Numero}, complemento: {Complemento}, bairro: {Bairro}," +
               $" cidade: {Cidade}, estado: {Estado}\n";
              
        }
    }

    
}

