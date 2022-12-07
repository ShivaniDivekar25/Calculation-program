using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Calculation
{
    internal class Calculator
    {
        public int AdditionofNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("sum of 2 numbers {0}",result);
            return result;
        }
        
    }
}
