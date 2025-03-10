using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class RangeChecker
    {
        public RangeChecker()
        {
        
            Console.WriteLine("Please enter a number between 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number <= 10)
            {
                Console.WriteLine("This is Valid");
            }
            else
            {
                Console.WriteLine("This is invalid");
            }
         }

}}
