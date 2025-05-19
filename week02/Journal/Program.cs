// Exceed
using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Prompt promptGenerator = new Prompt();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryResponse = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString("MM-dd-yyyy"),
                    _promptText = prompt,
                    _entryText = entryResponse
                };

                theJournal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
        }
    }
}