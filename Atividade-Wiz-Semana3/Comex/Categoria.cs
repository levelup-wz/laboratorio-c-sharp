using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria() 
        {
            Id = _id++;
        }

        public int DefineId()
        {
            return Id;
        }
    }
}
