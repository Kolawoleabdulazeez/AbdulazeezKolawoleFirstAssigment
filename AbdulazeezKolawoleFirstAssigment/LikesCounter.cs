using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    public class LikesCounter
    {
        public LikesCounter()
        {
            int likes = 0;
            List<string> likesList = new List<string>();

            while (true)
            {
                Console.WriteLine("Input your name to like this picture");
                string? input = Console.ReadLine();

                if (input == "ok")
                    break;
                else
                {
                    likes++;
                    if (likes <= 2)
                    {
                        likesList.Add(input);
                    }

                    else
                    {
                        if (likesList.Count == 2)
                        {
                            likesList.Add("1"); // Start counting additional likes
                        }
                        else
                        {
                            int lastLike = int.Parse(likesList[2]); // Get the count of others
                            likesList[2] = (lastLike + 1).ToString(); // Increment the count
                        }
                    }
                }

                // **Generate Output Based on Like Count**
                string? output = "";
                if (likes == 1)
                {
                    output = $"{likesList[0]} likes this.";
                }
                else if (likes == 2)
                {
                    output = $"{likesList[0]} and {likesList[1]} like this.";
                }
                else if (likes > 2)
                {
                    output = $"{likesList[0]}, {likesList[1]} and {likesList[2]} others like this.";
                }
                else
                {
                    output = "No likes yet.";
                }

                Console.WriteLine(output);

            }

        }
    }
}
