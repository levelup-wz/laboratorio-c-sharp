 
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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


        public Categoria(string nome, String status) {
            Id = ++ContId;
            Nome = nome;
            Status = status;
        }

        public string RetornaInfos()
        {
            return $"{Nome} ID número: {Id} - Status: {Status} ";
        }
    }
}

