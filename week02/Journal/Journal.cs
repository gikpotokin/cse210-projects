using System.Text.Json;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        try
        {
            string json = JsonSerializer.Serialize(entries,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filename, json);

            Console.WriteLine("Journal saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void Load(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string json = File.ReadAllText(filename);

            entries = JsonSerializer.Deserialize<List<Entry>>(json);

            Console.WriteLine("Journal loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public void Search(string keyword)
    {
        bool found = false;

        foreach (Entry entry in entries)
        {
            if ((entry.Response != null &&
                 entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                ||
                (entry.Prompt != null &&
                 entry.Prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                ||
                (entry.Mood != null &&
                 entry.Mood.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching entries found.");
        }
    }
}