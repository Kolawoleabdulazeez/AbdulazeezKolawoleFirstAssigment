using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class UniqueEntryChecker
    {
        public UniqueEntryChecker()
        {

                Console.WriteLine("Please continue entering numbers or enter 'quit' to stop.");

                HashSet<string> uniqueList = new HashSet<string>();

                while (true)
                {
                    string? entry = Console.ReadLine();

                    if (entry.ToLower() == "quit")
                    {
                        Console.WriteLine("Unique entries collected so far:");
                        Console.WriteLine(string.Join(", ", uniqueList));
                        break;
                    }

                    uniqueList.Add(entry);
                }

        }
    }
}
