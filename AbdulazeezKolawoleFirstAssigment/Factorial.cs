using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
   public  class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("Please input the number you would like to check the factorial");

            int num = Convert.ToInt32(Console.ReadLine());

            static int Factorial(int num)
            {
                if (num < 0)
                {
                    return -1;
                }
                if (num == 0 || num == 1)
                {
                    return 1;
                }
                return num * Factorial(num - 1);
            }
            int result = Factorial(num);
            Console.WriteLine(result);
        }
    }
}
