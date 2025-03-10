using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    class TimeChecker
    {
        public TimeChecker()
        {

                Console.WriteLine("Please input a valid time");

                string? entry = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entry))
                {
                    Console.WriteLine("Invalid Time");
                }

                // Try to parse the entry as a DateTime
                if (DateTime.TryParse(entry, out DateTime enteredDate))
                {
                    // Extract the time part of the DateTime (ignoring the date)
                    TimeSpan enteredTime = enteredDate.TimeOfDay;

                    // Compare the time part to see if it is within the valid range (00:00 to 23:50)
                    TimeSpan startTime = TimeSpan.Parse("00:00");
                    TimeSpan endTime = TimeSpan.Parse("23:50");

                    if (enteredTime >= startTime && enteredTime <= endTime)
                    {
                        Console.WriteLine("This is a valid time");
                    }
                    else
                    {
                        Console.WriteLine("This is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
        }
    }
}
