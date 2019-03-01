using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To start the calculator press Enter");
            Console.ReadLine();

            Console.WriteLine("Please enter your first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please enter your arithmetic operation sign e.g(+,-,*,/)");
            string operationSign = Console.ReadLine();

            Console.WriteLine("Please enter your second number:");
            string secondNumber = Console.ReadLine();

            int firstNum;
            int secondNum;

            int result = 0;

            bool convertFirstNum = int.TryParse(firstNumber, out firstNum);
            bool convertSecondNum = int.TryParse(secondNumber, out secondNum);

            if (operationSign != "/" && operationSign != "*" && operationSign != "+" && operationSign != "-")
            {
                Console.WriteLine("Invalid  arithmetic operation sign!");
            }

            else if ((firstNum > 0 || firstNum < 0) && (secondNum >= 0 || secondNum < 0) ) {
                if(operationSign == "+")
                {
                    result = firstNum + secondNum;
                }
                else if (operationSign == "-")
                {
                    result = firstNum - secondNum;
                }
                else if (operationSign == "*")
                {
                    result = firstNum * secondNum;
                }
                else if (operationSign == "/")
                {
                    result = firstNum / secondNum;
                }
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Please input numbers or first number that is higher than 0!");
                Console.ReadLine();
            }

            
            Console.ReadLine();

        }
    }
}
