using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1.MyClases
{
    public class OtherPerson : Employee
    {

        public OtherPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = Role.Other;
            WorkCardNumber = SetWorkCardNumber();
        }

        public override double GetSalary()
        {
            return Salary;
        }



    }
}
