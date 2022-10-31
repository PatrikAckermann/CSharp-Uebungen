using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Aufgaben
{
    internal class hourglass
    {
        public static void run()
        {
            Console.WriteLine("Welcome to the Hourglass program!");
            var input = "a";
            int height = 0;
            while (true)
            {
                Console.WriteLine("How tall should the hourglass be?");
                input = Console.ReadLine();
                decimal convertedInput = 0;
                if (Regex.IsMatch(input, @"^\d+$") == true)
                {
                    convertedInput = Convert.ToDecimal(input);
                } else {
                    Console.WriteLine("Invalid input: Only numbers are allowed.");
                    continue;
                }
                if (convertedInput % 2 == 0)
                {
                    Console.WriteLine("The height isn't allowed to be even. It needs to be odd.");
                    continue;
                }
                if (convertedInput < 3)
                {
                    Console.WriteLine("The Hourglass is not tall enough. It needs to be atleast 3 lines tall.");
                    continue;
                }
                if (convertedInput > 20)
                {
                    Console.WriteLine("The Hourglass is too tall. It needs to be less than 20 lines tall.");
                    continue;
                }
                height = Convert.ToInt32(Math.Ceiling(convertedInput / 2));
                break;
            }

            var pyramidList = pyramid.getPyramid(height);
            List<string> invertedPyramidList = new List<string>();
            foreach(string row in pyramidList)
            {
                invertedPyramidList.Insert(0, row);
            }
            invertedPyramidList.RemoveAt(invertedPyramidList.Count - 1);

            foreach(string row in invertedPyramidList)
            {
                Console.WriteLine(row);
            }
            foreach(string row in pyramidList)
            {
                Console.WriteLine(row);
            }
        }
    }
}
