using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambaExpressions
{
    internal class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        // Constructor
        public Person(string Name, int Age, string Gender, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
        }
    }
}
