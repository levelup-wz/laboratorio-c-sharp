using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comex
{
    public class Categoria
    {
        private int _id;
        private string _nome;
        private string _status;

        public int Id { get { return _id; } set { _id = value; } }

        public string Nome { get { return _nome; } set { _nome = value; } }

        public string Status { get { return _status; } set { _status = value; } }
    }
}
