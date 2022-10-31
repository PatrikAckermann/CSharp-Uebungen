using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Mini_Aufgaben
{
    internal class pyramid
    {
        public static void run()
        {
            int convertedInput = 0;
            Console.WriteLine("Welcome to the pyramid program!");
            while (true)
            {
                Console.WriteLine("How many lines tall should the pyramid be? (max. 20)");
                var input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^\d+$") == false)
                {
                    Console.WriteLine("The input is invalid. Only numbers allowed.");
                    continue;
                }
                convertedInput = Convert.ToInt32(input);
                if (convertedInput < 2)
                {
                    Console.WriteLine("The pyramid is not tall enough. It needs to be atleast 2 lines tall.");
                    continue;
                } else if (convertedInput > 20)
                {
                    Console.WriteLine("The pyramid is too tall. The maximum is 20 lines.");
                } else
                {
                    break;
                }
            }

            var pyramidList = getPyramid(convertedInput);
            foreach (string row in pyramidList)
            {
                Console.WriteLine(row);
            }
        }

        public static List<string> getPyramid(int height)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < height; i++)
            {
                string row = "";
                for (int j = 0; j < height - i; j++)
                {
                    row += " ";
                }
                for (int j = 0; j < i; j++)
                {
                    row += "**";
                }
                row += "*";
                output.Add(row);
            }
            return output;
        }
    }
}
