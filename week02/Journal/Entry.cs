using System;

class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public Entry() : this(DateTime.MinValue, "", "", "Unspecified")
    {
    }

    public Entry(DateTime date, string prompt, string response, string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public int GetWordCount()
    {
        return Response.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void Display()
    {
        Console.WriteLine("Date: " + Date.ToString("yyyy-MM-dd HH:mm"));
        Console.WriteLine("Prompt: " + Prompt);
        Console.WriteLine("Mood: " + Mood);
        Console.WriteLine("Response (" + GetWordCount() + " words): " + Response);
        Console.WriteLine(new string('-', 50));
    }
}
