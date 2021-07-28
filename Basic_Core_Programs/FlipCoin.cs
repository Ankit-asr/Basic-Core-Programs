using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class FlipCoin
    {
        public double flip;
        public int countHeads = 0;
        public int countTails = 0;
        public double result = 0.0;
        public void Percentage()
        {
            Console.WriteLine("Enter the number of times to flip a coin");
            double number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Random random = new Random();
                flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("TAILS");
                    countTails++;

                }
                else
                {
                    Console.WriteLine("HEADS");
                    countHeads++;
                }
            }
            result = (countHeads / number) * 100.0;
            Console.WriteLine("Percentage of Heads : " + result);
            result = (countTails / number) * 100.0;
            Console.WriteLine("Percentage of Tails : " + result);

        }
    }
}
