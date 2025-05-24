// I made it so that the punctuation is separate from the words in the verse, so that there is not a wrong number of "_" when
// looking at the hidden words.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }

            else
            {
                Console.Clear();
                break;
            }
        }

    }
}