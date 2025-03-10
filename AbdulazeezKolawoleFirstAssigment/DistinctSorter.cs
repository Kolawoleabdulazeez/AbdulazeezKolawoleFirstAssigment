using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class DistinctSorter
    {
        public DistinctSorter()
        {
            List<string> myList = new List<string>();
            Console.WriteLine("Please enter 5 distinct numbers:");

            int count = 0;
            while (true)
            {
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    // Check if the number is already in the list
                    if (!myList.Contains(input))
                    {
                        count++;
                        myList.Add(input);
                    }
                    else
                    {
                        Console.WriteLine($"'{input}' has already been entered. Please enter a distinct number.");
                    }

                    // If we have 5 distinct numbers, break the loop and sort the list
                    if (count == 5)
                    {
                        myList.Sort(); // Sorts the list
                        string output = string.Join(", ", myList); // Join the list into a single string
                        Console.WriteLine($"Sorted numbers: {output}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"'{input}' is not a valid integer.");
                }

            }
        }
    }
}
