using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Aplication.Clases
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Age { get; set; }
        private long SSN { get; set; }
        public bool LoyalBuyerCard { get; set; }
        public string Talk { get; set; }
        public string Payment { get; set; }

        public Person(string firstName, string lastName, DateTime age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = GenerateSSN();
            LoyalBuyerCard = GenerateCardStatus();
        }

        public Person()
        {

        }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999);
        }

        private bool GenerateCardStatus()
        {
            return new Random().Next(100) % 2 == 0;
        }

        public long GetSSN()
        {
            return SSN;
        }

        public bool BuyLoyalBuyerCard()
        {
            return LoyalBuyerCard = true;
        }
        
    }
}
