using Calculation;
using System;

namespace Testprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculator calculator = new Calculator(); ;
            Console.WriteLine("Please enter 1st number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            calculator.AdditionofNumbers(firstNumber, secondNumber);
            Console.ReadLine();
        }
    }
}