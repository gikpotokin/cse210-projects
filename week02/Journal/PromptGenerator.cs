public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I met today?",
        "What made me smile today?",
        "What was the best part of my day?",
        "How did I help someone today?",
        "What challenged me today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What goal did I accomplish today?",
        "How did I see the hand of the Lord today?",
        "If I could repeat one moment today, what would it be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}