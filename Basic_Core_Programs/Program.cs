using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine(" Program Menu");
            Console.WriteLine("Press 1 for Flip Coin");
            Console.WriteLine("Press 2 for Leap Year");
            Console.WriteLine("Press 3 for Power Of Two");
            Console.WriteLine("Press 4 for Harmonic Number");
            Console.WriteLine("Press 5 for Prime Factor");
            Console.WriteLine("Press 6 for Quotient And Remainder");
            Console.WriteLine("Press 7 for Swap Numbers");
            Console.WriteLine("Press 8 for Even or Odd");
            Console.WriteLine("Press 9 for Vowel Or Constant");
            Console.WriteLine("Press 10 for Largest Among Three Numbers");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You choose Flip Coin Program");
                    FlipCoin obj1 = new FlipCoin();
                    obj1.Percentage();
                    break;
                case 2:
                    Console.WriteLine("You choose Leap Year Program");
                    LeapYear obj2 = new LeapYear();
                    obj2.CheckLeapYear();
                    break;
                case 3:
                    Console.WriteLine("You choose Power of Two Program");
                    PowerTwo obj3= new PowerTwo();
                    obj3.Table();
                    break;
                case 4:
                    Console.WriteLine("You choose Harmonic Number Program");
                    HarmonicNumber obj4 = new HarmonicNumber();
                    obj4.PrintHarmonic();
                    break;
                case 5:
                    Console.WriteLine("You choose Prime Factors Program");
                    PrimeFactors obj5 = new PrimeFactors();
                    obj5.PrintPrimeFactors ();
                    break;

                case 6:
                    Console.WriteLine("You choose Quotient and Remainder Program");
                    QuotientAndRemainder obj6 = new QuotientAndRemainder();
                    obj6.Compute();
                    break;
                case 7:
                    Console.WriteLine("You choose Swap Two Numbers Program");
                    SwapTwoNumbers obj7 = new SwapTwoNumbers();
                    obj7.Swap();
                    break;

                case 8:
                    Console.WriteLine("You choose Even Or Odd Program");
                    EvenOdd obj8 = new EvenOdd();
                    obj8.CheckEvenOdd();
                    break;
                case 9:
                    Console.WriteLine("You choose Vowel Or Consonant Program");
                    Alphabet obj9 = new Alphabet();
                    obj9.CheckVowelOrConsonant();
                    break;
                case 10:
                    Console.WriteLine("You choose Largest Among Three Numbers Program");
                    LargestAmongThree obj10 = new LargestAmongThree();
                    obj10.CheckLargest();
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Choice ");
                    break;

            }
        }
    }
}

                   