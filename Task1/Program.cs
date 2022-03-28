using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            if(text.Length <= 5)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(text.Substring(text.Length - 5, 5));
            }
        }
    }
}
