 
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

        public int Id { get; }
        public static int ContId = 1;
        public string Nome { get; set; }
        public string Status { get; set; }
        public Categoria CategoriaClasse { get; set; }


        public Categoria(string nome, String status = "Ativa") {
            Id = ++ContId;
            Nome = nome;
            Status = status;
            if(ContId <= 0)
            {
                throw new ArgumentException("O ID não pode ser menor ou igaul a zero");
            }
            if (nome.Length <= 3)
            {
                throw new ArgumentException("O nome deve ter mais que três letras");
            }
            if (status.Equals("Ativa") || status.Equals("Inativa"))
            {
                
                Nome = nome;
                Status = status;
                Console.WriteLine($"A categoria {Nome} foi criada com sucesso!!!");
                Console.WriteLine($"{Nome} ID número: {Id} - Status: {Status} ");
            
            }
            else
            {
                throw new ArgumentException("O argumento status deve ser ATIVA ou INATIVA");


            }

        }

        public string RetornaInfos()
        {
            return $"{Nome} ID número: {Id} - Status: {Status} ";
        }


    }

        


}

