using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Aplication.Clases
{
    public class Cart
    {
        private long SN { get; set; }
        public List<Product> Products { get; set; }
        public double CartTotalPrice { get; set; }
        
        public Cart()
        {
            SN = GenerateSN();
            Products = new List<Product>();
        }


        private long GenerateSN()
        {
            return new Random().Next(100000, 999999);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
                
            }
            return total;
        }
        public double GetTotalPriceWithDiscount(int discount)
        {
            double total = 0;
            foreach (var product in Products)
            {
                total += product.Price;

            }
            if (discount > 0)
            {
                return total - ((total * discount) / 100);
            }
            else return total;
        }
    }

    
}
