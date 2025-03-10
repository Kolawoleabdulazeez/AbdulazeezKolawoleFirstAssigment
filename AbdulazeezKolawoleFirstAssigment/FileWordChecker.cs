using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    class FileWordChecker
    {
        public FileWordChecker()
        {
            Console.WriteLine("Please enter a textfile that you would like to check the longest word");
            Console.WriteLine("Please enter file path");


            while (true)
            {
                string? path = Console.ReadLine();
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine(content);

                    var words = Regex.Split(content, @"\W+")
                                                .Where(word => !string.IsNullOrEmpty(word))  // Filter out any empty strings
                                                .ToList();
                    string? longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();



                    // Displaying the longest word
                    Console.WriteLine("Longest word is:" + longestWord);
                    break;
                }
                Console.WriteLine("The file was not found. Please check the path.");
                continue;
            }

        }
    }
}
