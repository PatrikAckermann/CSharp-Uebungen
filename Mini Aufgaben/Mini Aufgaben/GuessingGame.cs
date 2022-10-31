using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Aufgaben
{
    internal class GuessingGame
    {
        public static void run()
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            var n1 = "";
            var n2 = "";
            while (true)
            {
                Console.WriteLine("Pick a starting number: ");
                n1 = Console.ReadLine();
                if (Regex.IsMatch(n1, @"^\d+$") == false)
                {
                    Console.WriteLine("Your input isn't a number. Try again.");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("Pick the ending number: ");
                n2 = Console.ReadLine();
                if (Regex.IsMatch(n2, @"^\d+$") == false)
                {
                    Console.WriteLine("Your input isn't a number. Try again.");
                    continue;
                }
                break;
            }

            int min = Convert.ToInt32(n1);
            int max = Convert.ToInt32(n2);

            Random rnd = new Random();
            int n = rnd.Next(Convert.ToInt32(n1), Convert.ToInt32(n2) + 1);

            Console.WriteLine(n);

            bool guessed = false;
            while (guessed == false)
            {
                Console.WriteLine("Guess a number: ");
                var guess = Console.ReadLine();
                if (Regex.IsMatch(guess, @"^\d+$") == false)
                {
                    Console.WriteLine("Your input isn't a number. Try again.");
                    continue;
                }
                int convertedGuess = Convert.ToInt32(guess);
                if (convertedGuess < min || convertedGuess > max){
                    Console.WriteLine("The number is outside your specified range.");
                } else if (convertedGuess < n)
                {
                    Console.WriteLine("The number is bigger than your guess.");
                } else if (convertedGuess > n)
                {
                    Console.WriteLine("The number is smaller than your guess.");
                } else {
                    guessed = true;
                    Console.WriteLine("You guessed the number!");
                }
            }
        }
    }
}
