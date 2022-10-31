using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Aufgaben
{
    internal class dice
    {
        public static void run()
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to the dice program!");
            while(true)
            {
                Console.WriteLine($"You got a {rnd.Next(1, 7)}.\n\nDo you want to roll the dice again? (y/n)");
                var input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
