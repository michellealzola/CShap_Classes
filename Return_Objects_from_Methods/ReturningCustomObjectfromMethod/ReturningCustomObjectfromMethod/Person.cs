using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningCustomObjectfromMethod
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }
        
    }
}
