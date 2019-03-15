using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1.MyClases
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Position { get; set; }

        public enum Role
        {
            Sales,
            Manager,
            Other
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name:{FirstName} , Last Name:{LastName} , Salary:{Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }

}
