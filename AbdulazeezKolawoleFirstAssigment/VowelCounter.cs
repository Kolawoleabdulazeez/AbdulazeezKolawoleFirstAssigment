using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class VowelCounter
    {
        public VowelCounter()
        {
            Console.WriteLine("Please enter an english word");

            int counter = 0;
            string englishVowels = "aeiou";
            string? entry = Console.ReadLine().ToLower();

            foreach (char letter in entry)
            {
                if (englishVowels.Contains(letter))  // Check if the letter is a vowel
                {
                    counter++;
                }
            }

            Console.WriteLine(counter + " letters are vowels in " + entry);
        }
    }
}
