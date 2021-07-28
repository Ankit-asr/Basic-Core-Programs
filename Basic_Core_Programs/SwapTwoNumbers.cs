using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.Write("After swap first number is "+ number1 + " and second number is "+number2);

        }
    }
}
