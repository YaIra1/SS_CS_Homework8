using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    public class Teacher : Staff
    {
        private string _subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            _subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher {Name} of subject: {_subject} has salary: ${Salary}");
        }
    }
}
