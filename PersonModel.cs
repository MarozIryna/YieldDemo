using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo
{
    internal class PersonModel
    {
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine(value: $"Initialized user {FirstName} {LastName}");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
