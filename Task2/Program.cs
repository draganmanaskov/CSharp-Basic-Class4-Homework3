using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
