using System.Runtime.InteropServices;

namespace FileReaderWriter
{
    internal class MyFileReaderWriter
    {
        static string[] reader(string filePath)
        {
            string[] lines = File.ReadAllLines("day_on_earth.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            return(lines);
        }

        static void writer(string filePath, string text)
        {
            while(true)
            {
                if (File.Exists(filePath))
                {
                    using(StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(text);
                    }
                    break;
                } 
                else
                {
                    Console.WriteLine("File doesn't exist.");
                    continue;
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the Rader and Writer Program.");
            while (true)
            {
                Console.WriteLine("\nWhat is the path to the file?");
                var path = Console.ReadLine();
                if (!File.Exists(path))
                {
                    Console.WriteLine("This file doesn't exist.");
                    continue;
                }
                Console.WriteLine("Do you want to read or write to a file?");
                var input = Console.ReadLine();
                input = input.ToLower();
                if (input == "r" || input == "read")
                {
                    reader(path);
                }
                else if (input == "w" || input == "write")
                {
                    Console.WriteLine("What do you want to write to the file?");
                    var text = Console.ReadLine();
                    writer(path, text);
                    Console.WriteLine("Written to file successfully.");
                }
            }
        }
    }
}
