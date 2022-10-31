using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Aufgaben
{
    internal class FizzBuzz
    {
        public static void run()
        {
            for (int i = 1; i <= 100; i++)
            {
                var n = "";
                if (i % 3 == 0) { n += "Fizz"; }
                if (i % 5 == 0) { n += "Buzz"; }
                if (n == "") { n = i.ToString(); }
                Console.WriteLine(n);
            }
        }
    }
}
