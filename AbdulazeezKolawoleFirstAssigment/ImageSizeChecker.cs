using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulazeezKolawoleFirstAssigment
{
    class ImageSizeChecker
    {
        public ImageSizeChecker()
        {

            Console.WriteLine("Please enter width and height of your image");
            Console.WriteLine("Enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int height = Convert.ToInt32(Console.ReadLine());

            string result = width == height ? "square" : (width > height ? "landscape" : "portrait");
            Console.WriteLine("The image is " + result);


        }
    }
}
