using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Dallas McCool", "Statistics", "7.3", "11-24");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Mary McCool", "Creative Writing", "Next Summer");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}