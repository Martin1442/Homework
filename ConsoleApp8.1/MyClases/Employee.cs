using System;
using System.Collections.Generic;



namespace ConsoleApp8._1.MyClases
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Role Position { get; set; }
        protected int WorkCardNumber { get; set; }


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

        protected int SetWorkCardNumber()
        {
            return WorkCardNumber = new Random().Next(1000000, 9999999);
        }

        public int GetWorkCardNumber()
        {
            return WorkCardNumber;
        }
    }

}
