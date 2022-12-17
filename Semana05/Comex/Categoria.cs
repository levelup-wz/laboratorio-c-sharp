 
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Comex
{
    public class Categoria
    {
       
        public int Id { get; set; }
        public static int ContId = 0;
        public string Nome { get; set; }
        public string Status { get; set; }
        public Categoria CategoriaClasse { get; set; }


        public Categoria(string nome, String status = "Ativa") {
            Id = ++ContId;
            Nome = nome;
            Status = status;
        }

        public void  ValidacaoDeCategoria(string nome, String status)
        {
            if(Id <= 0)
            {
                throw new ArgumentException("O ID deve ser maior do que zero");
            }
            if(nome.Length <= 3) 
            {
                throw new ArgumentException("O nome deve ter mais que três letras");
            }
            if(status != "Ativa" || status != "Inativa")
            {
                throw new ArgumentException("Status deve ser Ativa ou Inativa");
            }
            else
            {
                Id = ++ContId;
                Nome = nome;
                Status = status;
                Console.WriteLine($"A categoria {Nome} foi criada com sucesso!!!");
            }

        }
      

        public string RetornaInfos()
        {
            return $"{Nome} ID número: {Id} - Status: {Status} ";
        }
    }
}

