using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public Person(string name, string lastName, string email, string adress)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Adress = adress;
        }
    }
}
