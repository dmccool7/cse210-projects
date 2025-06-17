// Added a sound to the program when you record an event using Console.Beep().
// Added a bonus that you get every 10 recorded goals that pops a message up in green colored text and gives you 250 bonus points.
// The count towards the bonus is saved in the file as well.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}