using Mini_Aufgaben;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Mini_Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to the Mini Exercises.\n1: Roll a Dice\n2: FizzBuzz\n3: Guessing Game\n4: Pyramid\n5: Hourglass\n6: Exit\n Choose a number: ");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    dice.run();
                } else if (input == "2") 
                {
                    FizzBuzz.run();
                } else if (input == "3") 
                {
                    GuessingGame.run();
                } else if (input == "4")
                {
                    pyramid.run();
                } else if (input == "5")
                {
                    hourglass.run();
                } else if (input == "6")
                {
                    Environment.Exit(1);
                } else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}