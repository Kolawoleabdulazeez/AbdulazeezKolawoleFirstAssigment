using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class ReverseName
    {
        public ReverseName()
        {

            Console.WriteLine("Please enter your name");

            string? yourName = Console.ReadLine();
            char[] nameArray = yourName.ToArray();
            char[] reverseArray = nameArray.Reverse().ToArray();

            Console.WriteLine(string.Join("", reverseArray));  // No commas

        }
    }
}

