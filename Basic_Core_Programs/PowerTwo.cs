using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class PowerTwo
    {
        public void Table()
        {
            int n ,i ;
            Console.WriteLine("Please Enter n , Power of 2 till which you want the table");
            n = Convert.ToInt32(Console.ReadLine());
            if (n != 0 && n < 31)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("2*" + i + "=" + 2 * i);
                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct value of n ");

            }
        }
    }

}