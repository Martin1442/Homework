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

            string operationSign;
            string firstNumber;
            string secondNumber;
            double firstNum;
            double secondNum;
            double result = 0;
            int counter = 0;
            var history = new string[0];
            
            

            while (true)
            {
                #region Operation
                do
                {
                    Console.WriteLine("Please enter your arithmetic operation sign e.g(+,-,*,/)");
                    operationSign = Console.ReadLine();
                    if (operationSign != "/" && operationSign != "*" && operationSign != "+" && operationSign != "-")
                    {
                        Console.WriteLine("Invalid  arithmetic operation sign!");
                        continue;
                    }
                    Array.Resize(ref history, history.Length + 1);
                    history[counter] = operationSign;
                    counter++;
                    break;
                } while (true);
                #endregion
                #region FirstNumber
                do
                {
                    Console.WriteLine("Please enter your first number:");
                    firstNumber = Console.ReadLine();

                    bool convertFirstNum = double.TryParse(firstNumber, out firstNum);
                    if (firstNum == 0)
                    {
                        Console.WriteLine("Invalid number");
                        continue;
                    }
                    Array.Resize(ref history, history.Length + 1);
                    history[counter] = firstNumber;
                    counter++;
                    break;
                } while (true);
                #endregion
                #region SecondNumber
                do
                {
                    Console.WriteLine("Please enter your second number:");
                    secondNumber = Console.ReadLine();
                    if (secondNumber == "0")
                    {
                        secondNum = 0;
                        Array.Resize(ref history, history.Length + 1);
                        history[counter] = secondNumber;
                        counter++;
                        break;
                    }

                    bool convertSecondNum = double.TryParse(secondNumber, out secondNum);
                
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Invalid number");
                        continue;
                    }
                    Array.Resize(ref history, history.Length + 1);
                    history[counter] = secondNumber;
                    counter++;
                    break;
                }
                while (true);
                #endregion
                #region Calculation
                if ((firstNum > 0 || firstNum < 0) && (secondNum >= 0 || secondNum < 0))
                {
                    if (operationSign == "+")
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
                #endregion
                Console.WriteLine("If you want to continue type anything , or if you want to quit type:N");
                string answer = Console.ReadLine();
                if (answer == "N")
                {
                    for (var i = 0; i < history.Length; i++)
                    {
                        
                        Console.WriteLine("History: operation " + history[i] + " with " + history[++i] + " , " + history[++i]);
                    }
                    
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
