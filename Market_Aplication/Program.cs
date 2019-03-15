using System;
using System.Collections.Generic;
using Market_Aplication.Clases;

namespace Market_Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cart = new Cart();
            Product[] allProducts = new Product[] {
                new Product("Zelka piece", "Vegetable", "Macedonia", 35.50),
                new Product("Zlaten Dab", "Alcohol", "Macedonia", 90.00),
                new Product("Nutela 200gr", "Cocolate Cream", "Macedonia", 171.50),
                new Product("Coca Cola 1.5L", "Drink", "Macedonia", 64.99),
                new Product("Vodka", "Alcohol", "Macedonia", 1040.99)
            };
            
            while (true)
            {

                Console.WriteLine("Enter your first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter person date of birth (format: yyyy/mm/dd)");
                string dateOfBirtStr = Console.ReadLine();

                DateTime defaultDAte = new DateTime();

                DateTime dateOfBirthDate = DateTime.MinValue;
                DateTime.TryParse(dateOfBirtStr, out dateOfBirthDate);

                while (true)
                {
                    if (dateOfBirthDate.Year == defaultDAte.Year)
                    {
                        Console.WriteLine("Enter person date of birth (format: yyyy/mm/dd)");
                        dateOfBirtStr = Console.ReadLine();
                        DateTime.TryParse(dateOfBirtStr, out dateOfBirthDate);
                        continue;
                    }
                    break;
                }
               
                var person = new Person(firstName, lastName, dateOfBirthDate);

                Console.WriteLine(person.LoyalBuyerCard);
                var cashier = new Person();

                Console.WriteLine($"\nChose products \nIf you are done type anything \n");
                
                int i = 1;
                foreach (var item in allProducts)
                {
                    Console.WriteLine($"{i++}.Product:{item.Name}, Description:{item.Description}, Declaration:{item.Declaration}, Price:{item.Price}");
                }

                while (true)
                {
                    string selectedProductIndexStr = Console.ReadLine();

                    int selectedProduct = -1;
                    Int32.TryParse(selectedProductIndexStr, out selectedProduct);

                    if (selectedProduct > 0)
                    {
                        if (allProducts.Length >= selectedProduct)
                        {
                            cart.AddProduct(allProducts[selectedProduct - 1]);
                            continue;
                        }
                        else break;
                        
                    }

                    cashier.Talk = "Cashier: Will that be all? If not type (NO)";
                    Console.WriteLine(cashier.Talk);

                    person.Talk = Console.ReadLine();

                    if (person.Talk == "NO")
                    {
                        Console.WriteLine("Chose products");
                        continue;
                    }
                    
                    for (int i1 = 0; i1 < cart.Products.Count; i1++) {
                        Product item = cart.Products[i1];
                        if (item.Description == "Alcohol")
                        {
                            var dateNowYear = DateTime.Now.Year;
                            var dateNowMonth = DateTime.Now.Month;
                            var dateNowDay = DateTime.Now.Day;
                            var personAge = dateNowYear - person.Age.Year;
                            if (personAge <= 18)
                            {
                                if (dateNowMonth > person.Age.Month)
                                {
                                    cashier.Talk = $"Cashier: Sorry you are not 18 years and you cant buy Alcohol,i will return {item.Name} back";
                                    Console.WriteLine(cashier.Talk);
                                    cart.RemoveProduct(item);
                                    --i1;
                                }
                                else if (dateNowDay > person.Age.Day)
                                {
                                    cashier.Talk = $"Cashier: Sorry you are not 18 years and you cant buy Alcohol,i will return {item.Name} back";
                                    Console.WriteLine(cashier.Talk);
                                    cart.RemoveProduct(item);
                                    --i1;
                                }
                            }
                        }
                    }
                    foreach (var item in cart.Products)
                    {
                        cashier.Talk = $"You have taken {item.Name} product";
                        Console.WriteLine(cashier.Talk);
                    }
                    break;
                }
                double totalPrice = cart.GetTotalPrice();
                int priceForDiscount = 1000;
                int discount = 10;
                int loyalDiscount = 15;
                int discountPercent = 0;

                if(totalPrice >= priceForDiscount)
                {
                    discountPercent += discount;
                }
                if (person.LoyalBuyerCard)
                {
                    discountPercent += loyalDiscount;
                }
                else if (!person.LoyalBuyerCard && totalPrice >= priceForDiscount )
                {
                    Console.WriteLine("Do you want to get LoyalBuyerCard?" + " YES / NO");
                    string answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        person.BuyLoyalBuyerCard();
                        discountPercent += loyalDiscount;
                    }
                }
                
                totalPrice = cart.GetTotalPriceWithDiscount(discountPercent);

                cashier.Talk = $"You need to pay {totalPrice}";
                Console.WriteLine(cashier.Talk);
                
                double convertedPayment = 0;
                while (true)
                {
                    Console.WriteLine("Please pay:");
                    person.Payment = Console.ReadLine();
                    bool convertPayment = double.TryParse(person.Payment, out convertedPayment);
                    if (convertedPayment == 0)
                    {
                        Console.WriteLine("Enter correct numbers to pay");
                        continue;
                    }
                    else if (totalPrice <= convertedPayment)
                    {
                        cashier.Talk = $"Thank you costumer. Bye!";
                        Console.WriteLine(cashier.Talk);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You need to pay {totalPrice} , plase pay the total price");
                        continue;
                    }
                }
                Console.ReadLine();
                break;
            }
            
        }
    }
}
