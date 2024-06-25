using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    internal class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Position { get; private set; }


        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public void SetPosition(string position)
        {
            this.Position = position;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Position: {Position}";
        }

    }
}
