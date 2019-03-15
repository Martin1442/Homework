using System;
using System.Collections.Generic;
using ConsoleApp8._1.MyClases;

namespace ConsoleApp8._1
{
    class Program
    {
        static void Main(string[] args)
        {

            var manager = new ManagerPerson("Bob", "Vilsky");

            var CardNumber = manager.GetWorkCardNumber();
            
            
            Console.WriteLine(CardNumber);
            Console.ReadLine();
        }
    }
}
