using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class PascalCaseGenerator
    {
        public PascalCaseGenerator()
        {
            Console.WriteLine("Please enter a few words separated by a space.");

            string? entries = Console.ReadLine();
            // Convert to lowercase and store it
            entries = entries.ToLower();

            string[] newArray = entries.Split(' ');

            // Capitalize each word
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = char.ToUpper(newArray[i][0]) + newArray[i].Substring(1);
            }
            // Join and display the capitalized words
            string result = string.Join("", newArray);
            Console.WriteLine(result);
        }
    }
}
