using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Data
{
    public class PersonManager
    {
        public static Models.Person GetPerson(string firstName, string lastName, string email, string adress)
        {
            Models.Person person = new Models.Person(firstName, lastName, email, adress);

            return person;
        }
    }
}
