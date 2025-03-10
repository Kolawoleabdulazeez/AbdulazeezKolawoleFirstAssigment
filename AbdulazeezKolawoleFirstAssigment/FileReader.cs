using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class FileReader
    {
        public FileReader()
        {
            Console.WriteLine("Please enter a textfile that you would like to count the number of word present in it");
            Console.WriteLine("Please enter file path");

            string? path = Console.ReadLine();
            string? content = File.ReadAllText(path);
            Console.WriteLine(content);

            var words = Regex.Matches(content, @"[\w'-]+");

            // Count the number of matches (words)
            int wordCount = words.Count;

            // Display the word count
            Console.WriteLine($"Number of words in the file: {wordCount}");
        }
    }
}
