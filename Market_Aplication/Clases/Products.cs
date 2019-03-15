using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Aplication.Clases
{
    public class Product
    {
        public string Name { get; set; }
        private long SN { get; set; }
        public string Description { get; set; }
        public string Declaration { get; set; }
        public double Price { get; set; }
        


        public Product(string name, string description, string declaration, double price)
        {
            Name = name;
            Description = description;
            Declaration = declaration;
            Price = price;
            SN = GenerateSN();
        }

        private long GenerateSN()
        {
            return new Random().Next(100000, 999999);
        }
        

    }
}
