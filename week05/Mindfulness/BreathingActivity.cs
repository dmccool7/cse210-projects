using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int cycle = 10;
        int totalCycles = _duration / cycle;

        for (int i = 0; i < totalCycles; i++)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}