using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator("+", 24, 32);
            Calculator("-", 24, 32);
            Calculator("*", 24, 32);
            Calculator("/", 324, 33);
            Calculator("/", 324, 0);
        }

        static void Calculator(string operatorVar, int numberOne, int numberTwo)
        {
            switch (operatorVar)
            {
                case "+":
                    Sum(numberOne, numberTwo);
                    break;
                case "-":
                    Subtract(numberOne, numberTwo);
                    break;
                case "*":
                    Multiplication(numberOne, numberTwo);
                    break;
                case "/":
                    Division(numberOne, numberTwo);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }

        private static void Division(int numberOne, int numberTwo)
        {
            if(numberTwo == 0)
            {
                Console.WriteLine("Can't divide with 0");
                return;
            }

            Console.WriteLine($"{numberOne} /{numberTwo} = {((decimal)numberOne / numberTwo).ToString("#.##")}");
        }

        private static void Multiplication(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
        }

        private static void Subtract(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
        }

        static void Sum(int numberOne, int numberTwo)
        {
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        }
    }
}
