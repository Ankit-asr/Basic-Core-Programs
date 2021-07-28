using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Alphabet
    {
        public void CheckVowelOrConsonant()
        {
            char alphabet, lowerCaseAlphabet;
            Console.WriteLine("Enter an Alphabet");
            alphabet = Convert.ToChar(Console.ReadLine());
            lowerCaseAlphabet = Char.ToLower(alphabet);
            if (lowerCaseAlphabet == 'a' || lowerCaseAlphabet == 'e' || lowerCaseAlphabet == 'i' || lowerCaseAlphabet == 'o' || lowerCaseAlphabet == 'u')
                Console.WriteLine("Alphabet is a Vowel");
            else
                Console.WriteLine("Alphabet is a Consonant");
        }
    }
}
