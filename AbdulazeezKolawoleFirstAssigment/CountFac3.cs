using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class CountFac3
    {
        public CountFac3()
        {
                Console.WriteLine("Write a number you would like check the number of divisor by 3");
                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;

                    }

                }
                Console.WriteLine("Number diviside by 3 with no remainder in " + num + " is " + count);
        }
    }
}
