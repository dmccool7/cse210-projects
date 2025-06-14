// First, I made it so in the ListingActivity, when a blank line is entered, it will not be added to the List.
// Then I 

using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string menuInput = "";
        while (menuInput != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                BreathingActivity activity = new BreathingActivity("", "");
                activity.Run();
            }
            else if (menuInput == "2")
            {
                ReflectingActivity activity = new ReflectingActivity("", "");
                activity.Run();
            }
            else if (menuInput == "3")
            {
                ListingActivity activity = new ListingActivity("", "");
                activity.Run();
            }
        }
    }
}