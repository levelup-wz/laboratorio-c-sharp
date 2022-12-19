using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entity
{
    public class Categories
    {
        private static int _id = 0;
        public int Id { get; set; }

        public string Name { get; set; }
        public string Status { get; set; }


        public Categories(string name, string status)
        {
            Id = _id++;
            Name = name;
            Status = status;
        }

    }
}
