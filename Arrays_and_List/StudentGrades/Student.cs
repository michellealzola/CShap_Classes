using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Student
    {
        public Student(int studentId, string name, double grade)
        {
            StudentID = studentId;
            Name = name;
            Grade = grade;
        }

        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
    }
}
