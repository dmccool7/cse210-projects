using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            number = SquareNumber(number);
            DisplayResult(number, name);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string favNumber = Console.ReadLine();
            int num = int.Parse(favNumber);
            return num;
        }

        static int SquareNumber(int number)
        {
            number *= number;
            return number;
        }

        static void DisplayResult(int number, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        Main();
    }
}