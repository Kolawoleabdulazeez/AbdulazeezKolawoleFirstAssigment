using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class IsConsecutive
    {
        public IsConsecutive()
        {

            Console.WriteLine("Please enter a hyphen-separated list of numbers to check if they are consecutive:");

            while (true)
            {
                string? input = Console.ReadLine();

                // Validate empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input. Please enter numbers separated by hyphens.");
                    continue;
                }

                List<int> listInput;

                listInput = input.Split('-').ToList().ConvertAll(int.Parse);


                // Ensure list has at least two numbers
                if (listInput.Count < 2)
                {
                    Console.WriteLine("Invalid input. Enter at least two numbers.");
                    continue;
                }

                int step = listInput[1] - listInput[0];
                listInput.Sort();

                bool isConsecutive = true;
                for (int i = 1; i < listInput.Count; i++)
                {
                    if (listInput[i] != listInput[i - 1] + step)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                Console.WriteLine(isConsecutive ? $"The numbers are consecutive with a step of {step}." : "The numbers are NOT consecutive.");
                break;
            }
        }
    }
}
