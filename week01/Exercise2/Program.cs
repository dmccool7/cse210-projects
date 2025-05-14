using System;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        string plusMinus; 
        int lastNumber = grade % 10;

        if (lastNumber >= 7)
        {
            plusMinus = "+";
        }

        else if (lastNumber < 3)
        {
            plusMinus = "-";
        }

        else
        {
            plusMinus = "";
        }

        if (grade >= 93)
        {
            plusMinus = "";
        }

        if (letter == "F")
        {
            plusMinus = "";
        }

        Console.WriteLine($"{letter}{plusMinus}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed.");
        }

        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}