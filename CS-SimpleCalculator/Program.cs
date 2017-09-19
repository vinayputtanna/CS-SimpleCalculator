using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter the first operand:");
            int firstOperand = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            string op=Console.ReadLine();
            Console.WriteLine("Enter the second operator");
            int secondOperand = int.Parse(Console.ReadLine());
            switch (op)
            {
                case "+":
                    Console.WriteLine(string.Format("The sum of {0} and {1} is {2}", firstOperand, secondOperand,(firstOperand + secondOperand)));
                    break;
                case "-":
                    Console.WriteLine(string.Format("The difference of {0} and {1} is {2}", firstOperand, secondOperand, (firstOperand - secondOperand)));
                    break;
                case "*":
                    Console.WriteLine(string.Format("The product of {0} and {1} is {2}", firstOperand, secondOperand, (firstOperand * secondOperand)));
                    break;
                case "/":
                    Console.WriteLine(string.Format("The quotient of {0} and {1} is {2}", firstOperand, secondOperand, (firstOperand / secondOperand)));
                    break;
                case "%":
                    Console.WriteLine(string.Format("The remainder of {0} and {1} is {2}", firstOperand, secondOperand, (firstOperand % secondOperand)));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadKey();
        }
    }
}
