using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class SumNum
    {
        public SumNum()
        {
                int sum = 0;
                string? userNum;

                Console.WriteLine("Please enter numbers  that you would like to add and press ok when you are done");

                while (true)
                {
                    Console.WriteLine("Enter a number");
                    userNum = Console.ReadLine();

                    if (userNum.ToLower() == "ok")
                    {
                        break;
                    }
                    if (int.TryParse(userNum, out int number))
                    {
                        sum += number;
                    }
                    else
                        Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
                }
                Console.WriteLine(sum);
            }
    }
}
