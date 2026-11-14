using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creative feature: each entry tracks mood and word count so the writer can reflect on feelings and writing habits over time.
        Journal journal = new Journal();
        string fileName = "journal.json";
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = journal.GetRandomPrompt();
                    Console.WriteLine("\nPrompt: " + prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("How are you feeling? ");
                    string mood = Console.ReadLine();
                    journal.AddEntry(new Entry(DateTime.Now, prompt, response, mood));
                    Console.WriteLine("Entry added.");
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile(fileName);
                    Console.WriteLine("Journal saved to " + Path.GetFullPath(fileName));
                    break;
                case "4":
                    journal.LoadFromFile(fileName);
                    Console.WriteLine("Journal loaded from " + Path.GetFullPath(fileName));
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 5.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
