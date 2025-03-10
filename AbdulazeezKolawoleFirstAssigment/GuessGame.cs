using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class GuessGame
    {
        public GuessGame()
        {
            Random rand = new Random();
            int num = rand.Next(1, 11);
            int count = 0;
            int maxAttempts = 4; // Limit attempts to prevent infinite loops

            Console.Write("Guess a number between 1 and 10: ");

            while (count <= maxAttempts)
            {
                int input;

                // Try to read user input and convert it to an integer
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input. Enter a number between 1 and 10.");
                    continue;
                }

                if (input == num)
                {
                    Console.WriteLine("You guessed right!");
                    return;
                }
                else
                {
                    Console.WriteLine("Try again.");
                    count++;
                }
            }

            Console.WriteLine($"Game over! The correct number was {num}.");
        }
    }
}
