using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1.MyClases
{
    public class SalesPerson : Employee
    {
        private double SuccesSaleRevenue { get; set; }


        public SalesPerson(string firstname, string lastname, int success)
        {
            FirstName = firstname;
            LastName = lastname;
            SuccesSaleRevenue = success;
            Salary = 500;
            Position = Role.Sales;
        }

        public void AddSuccessRevenue(double sucess)
        {
            SuccesSaleRevenue = sucess;
        }

        public override double GetSalary()
        {
            if (SuccesSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccesSaleRevenue > 2000 && SuccesSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else if (SuccesSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else return Salary;
        }
    }
}
