using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models.Entity
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        private static int _id = 0;
        public int Id { get; set; }

        public Client(string name, string lastName)
        {

            Name = name;
            LastName = lastName;
            Id = _id++;


        }

        public string GetFullName()
        {
            return $"{Name} {LastName}";
        }

    }
}
