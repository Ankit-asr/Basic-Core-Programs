using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class LargestAmongThree
    {
        public void CheckLargest()
        {
            int number1, number2, number3;
            Console.WriteLine("Enter the three numbers");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Largest of given numbers is ");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(number1);
            else
            {
                if (number2 > number3 && number2 > number1)
                    Console.WriteLine(number2);
                else
                    Console.WriteLine(number3);
            }
        }
    }
}

