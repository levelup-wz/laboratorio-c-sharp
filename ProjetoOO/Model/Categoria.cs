using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public override string ToString().
        {
            return Nome + " (" + Id + " - " + Status + ")";
        }
    }
}
