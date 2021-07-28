using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class HarmonicNumber
    {
        public void PrintHarmonic()
        {
            double i;
            double sum = 1;
            Console.WriteLine("Enter nth Harmonic Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                Console.Write("1/1");

                for (i = 2; i <= n; i++)
                {
                    sum = sum + (1 / i);
                    Console.Write( "+" + "1/" +i );
                }
                Console.WriteLine();
                Console.WriteLine("Nth number is : " + sum);

            }
            else
                Console.WriteLine("Entered nth number is equal to 0");
        }
    }
}