using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class ListChecker
    {
        public ListChecker()
        {
            Console.WriteLine("Please enter a comma-seperated list with at least 5 entries");

            while (true)
            {
                string? commaList = Console.ReadLine();

                //spliting the list entered

                List<string> newList = new List<string>(commaList.Split(','));

                //trimming whitespace in each entry 
                for (int i = 0; i < newList.Count; i++)
                {
                    newList[i] = newList[i].Trim();
                }

                if (newList.Count < 5)
                {
                    Console.WriteLine("List is invalid. Please retry");
                }
                else
                {
                    Console.WriteLine("List is valid");
                    Console.WriteLine(string.Join(",", newList));
                    break;
                }

            }
        }
    }
}
