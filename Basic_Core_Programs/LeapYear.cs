using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 && year < 10000)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    Console.WriteLine(+year + " is a Leap Year");
                else
                    Console.WriteLine(+year + " is not a Leap Year");
            }
            else
                Console.WriteLine("Entered year is not a four digit ");
        }
    }
}
