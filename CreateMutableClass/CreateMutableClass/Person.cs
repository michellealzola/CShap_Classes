using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMutableClass
{
    internal class Person
    {
        private string _name;
        private int _age;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }


        public override string ToString()
        {
            return $"Name: {this.Name} | Age: {this.Age}";
        }
    }
}
