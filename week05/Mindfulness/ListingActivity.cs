public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        GetRandomPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        var items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random p = new Random();
        int index = p.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            TimeSpan remaining = endTime - DateTime.Now;
            Console.WriteLine($"You have {remaining.Seconds} seconds left.");
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        return items;
    }
}