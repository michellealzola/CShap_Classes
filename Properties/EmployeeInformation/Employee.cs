using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private decimal _salary;
        private string _department;

        public Employee()
        {
            _id = 0;
            _name = string.Empty;   
            _salary = 0;
            _department = string.Empty;
        }

        public int ID {  get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public decimal Salary { get { return _salary; } set { _salary = value; } }  
        public string Department { get { return _department; } set { _department = value; } }
    }
}
