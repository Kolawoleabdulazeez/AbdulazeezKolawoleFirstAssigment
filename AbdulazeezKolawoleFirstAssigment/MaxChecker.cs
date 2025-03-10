using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class MaxChecker
    {
        public MaxChecker()
        {
            Console.WriteLine("Please enter two number");
            Console.WriteLine("Enter the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The larger number is " + Math.Max(firstNum, secondNum));
        }
    }
}
