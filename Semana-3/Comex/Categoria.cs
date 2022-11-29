﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(int id, string nome, string status = "ATIVA")
        {
            Id = id;
            Nome = nome;
            Status = status;
        }

        public string Informacoes()
        {
            return $"{Nome} ({Id} - {Status})";
        }
    }
}
