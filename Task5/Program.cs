using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array size
            Console.WriteLine("Enter number of elements");
            bool isValidNumberOfElements = int.TryParse(Console.ReadLine(), out int numberOfElements);

            if(!isValidNumberOfElements)
            {
                Console.WriteLine("Inavlid number of elemets");
                return;
            }

            int[] numberArray = GetArrayInput(numberOfElements);

            int threesNextToEacheother = 0;

            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                threesNextToEacheother += TwoThrees(numberArray[i], numberArray[i + 1]);
            }

            Console.WriteLine($"{threesNextToEacheother} times there are threes to each other");
        }

        // if there are threes next to each other add 1 to the count  
        public static int TwoThrees(int v1, int v2)
        {
            if( v1 == 3 && v2 == 3)
            {
                return 1;
            }

            return 0;
        }

        public static int[] GetArrayInput(int numberOfElements)
        {

            int[] tempArr = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Enter element no.{i + 1}");
                bool isValidParse = int.TryParse(Console.ReadLine(), out int number);

                //ask the user again, until we get a valid input
                if (!isValidParse)
                {
                    Console.WriteLine("Invalid Input! Please Enter a number");
                    i--;
                    continue;
                }

                //add number to array
                tempArr[i] = number;
            }

            return tempArr;
        }
    }
}
