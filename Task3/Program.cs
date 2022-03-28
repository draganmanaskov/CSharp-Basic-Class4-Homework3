using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string stringNumber = Console.ReadLine();

            bool isValidParse = int.TryParse(stringNumber, out int numberParsed);

            if(!isValidParse)
            {
                Console.WriteLine("Error! Invalid input");
                return;
            }

            int sum = 0;

            foreach( char character in stringNumber)
            {
                //transform char to int
                int number = character - '0';

                sum += number;
            }

            Console.WriteLine($"The sum of the digits is {sum}");

        }
    }
}
