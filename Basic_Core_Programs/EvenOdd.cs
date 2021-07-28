using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class EvenOdd
    {
        public void CheckEvenOdd()
        {
            int number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 ==0)
                Console.WriteLine( +number+" is Even");
            else
                Console.WriteLine(+number+" is Odd");
        }
    }
}
