/* Cayden Wagner
 * Simple Calculator
 * March 23 2022
 * */
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operator1;

            Console.Write("Enter a number: ");
            string num = (Console.ReadLine());
            try
            {
                num1 = Convert.ToDouble(num);
            }
            catch
            {
                Console.WriteLine($"Invalid operand was given: {num}");
                Console.WriteLine("A double was expected");
                return;
            }

            Console.Write("Enter a number: ");
            num = Console.ReadLine();
            try
            {
                num2 = Convert.ToDouble(num);
            }
            catch
            {
                Console.WriteLine($"Invalid operand was given: {num}");
                Console.WriteLine("A double was expected");
                return;
            }

            Console.Write("Enter an operator: ");
            string operatorStr = (Console.ReadLine());

            try
            {
                operator1 = Convert.ToChar(operatorStr);
            }
            catch
            {
                Console.WriteLine($"Invalid operator was given: {operatorStr}");
                Console.WriteLine("A char was expected");
                return;
            }

            if ('+' == operator1)
            {
                Console.WriteLine(num1 + num2);
            }
            else if ('-' == operator1)
            {
                Console.WriteLine(num1 - num2);
            }
            else if ('/' == operator1)
            {
                Console.WriteLine(num1 / num2);
            }
            else if ('*' == operator1)
            {
                Console.WriteLine(num1 * num2);
            }
            else if('%' == operator1)
            {
                Console.WriteLine(num1 % num2)
            }
            else
            {
                Console.WriteLine($"Unrecognized operator was given: {operator1}");
                Console.WriteLine($"Recognized operators include: +, -, %, *, /");
            }
        }
    }
}
