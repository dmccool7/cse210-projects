public class Prompt
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "Who did something kind to me today?",
        "What act of kindness did I do today?",
        "How did I improve myself today?",
        "How did I strengthen a relationship today?"
    };

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int indexPrompt = prompt.Next(_prompts.Count);
        return _prompts[indexPrompt];
    }
}