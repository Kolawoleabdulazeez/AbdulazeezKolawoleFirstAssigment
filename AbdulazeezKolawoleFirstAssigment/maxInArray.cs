using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class maxInArray
    {
        public maxInArray()
        {
            Console.WriteLine("Please input comma separated numbers that you would like to check it max");

            string[] newArrray = (Console.ReadLine()).Split(",");
            int[] intArray = Array.ConvertAll(newArrray, int.Parse);
            Array.Sort(intArray);
            int max = intArray[intArray.Length - 1];
            Console.WriteLine("This is the maximum of the array you inputed" + max);
        }
    }
}
