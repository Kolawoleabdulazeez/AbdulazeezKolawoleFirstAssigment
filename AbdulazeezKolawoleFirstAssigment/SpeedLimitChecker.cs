using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class SpeedLimitChecker
    {
        public SpeedLimitChecker()
        {

                Console.WriteLine("Please enter your speed limit");
                int speedLimit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter yout car speed");
                int speed = Convert.ToInt32(Console.ReadLine());

                if (speed <= speedLimit)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    double demeritPoints = (speed - speedLimit) / 5;
                    Console.WriteLine($"Demerit Points: {demeritPoints}");

                    if (demeritPoints >= 12)
                    {
                        Console.WriteLine("License Suspended");
                    }

                }
            }
    }
}
