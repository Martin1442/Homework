using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1.MyClases
{
    public class ManagerPerson : Employee
    {
        private double Bonus { get; set; }

        public ManagerPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = Role.Manager;
            WorkCardNumber = SetWorkCardNumber();

        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
