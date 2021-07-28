using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class QuotientAndRemainder
    {
        public void Compute()
        {
            double divisor;
            double dividend;
            double remainder;
            double quotient;
            Console.WriteLine("Enter the Dividend or the number you want to divide");
            dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Divisor or the number with you want to divide"+dividend);
            divisor = Convert.ToDouble(Console.ReadLine());
            remainder = dividend % divisor;
            quotient = dividend / divisor;
            Console.WriteLine("Quotient is :" + quotient);
            Console.WriteLine("Remainder is " + remainder);

        }
    }
}
