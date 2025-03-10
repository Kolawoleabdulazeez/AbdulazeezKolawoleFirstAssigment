using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class DuplicateChecker
    {
        public DuplicateChecker()
        {
            Console.WriteLine("Please enter a hyphen-separated list of numbers to check uniqueness:");

            while (true)
            {
                string? input = Console.ReadLine();

                // Exit if input is empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You didn't supply any information");
                    break;
                }

                string[] parts = input.Split('-');
                HashSet<int> uniqueNumbers = new HashSet<int>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int number))
                    {
                        if (!uniqueNumbers.Add(number)) // If Add returns false, it's a duplicate
                        {
                            Console.WriteLine("Duplicate");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter only numbers separated by hyphens.");
                        return;
                    }
                }

                Console.WriteLine("No Duplicates");
                break;
            }
        }
    }
}
