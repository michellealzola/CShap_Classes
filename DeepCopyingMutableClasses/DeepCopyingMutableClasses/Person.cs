using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyingMutableClasses
{
    internal class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person(string name, Address address)
        {
            Name = name; Address = address;
        }

        public Person(Person other)
        {
            Name = other.Name;
            Address = new Address(other.Address);
        }
    }
}
