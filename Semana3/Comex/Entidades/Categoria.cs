using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Categoria
    {
        private static int numId = 1;
        public int _id { get; private set; }
        public string _nome { get; private set; }
        public string _status { get; private set; }

        public Categoria(string nome, string status = "ativa")
        {
            _status = status.ToUpper();
            _nome = nome.ToUpper();
            _id = Categoria.numId;
            Categoria.numId++;
        }
        public void ListarCategoria()
        {
            Console.WriteLine($"{_nome} ({_id} - {_status})");
        }
    }
}
