
using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Creativity and Exceeding Requirements:
         * This program allows users to choose from three different scriptures: John 3:16, Proverbs 3:5-6, and Philippians 4:13. 
         * It also hides only words that have not already been hidden.
         */

        Console.WriteLine("================================");
        Console.WriteLine("       SCRIPTURE MEMORIZER");
        Console.WriteLine("================================");

        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Philippians 4:13");

        Console.Write("\nEnter your choice (1-3): ");
        string choice = Console.ReadLine();

        Reference reference;
        string text;

        switch (choice)
        {
            case "1":
                reference = new Reference("John", 3, 16);
                text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
                break;

            case "2":
                reference = new Reference("Proverbs", 3, 5, 6);
                text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
                break;

            case "3":
                reference = new Reference("Philippians", 4, 13);
                text = "I can do all things through Christ which strengtheneth me.";
                break;

            default:
                Console.WriteLine("Invalid choice. Using John 3:16.");
                reference = new Reference("John", 3, 16);
                text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
                break;
        }

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to hide three words.");
            Console.WriteLine("Type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nCongratulations! All words are hidden.");
        }
        else
        {
            Console.WriteLine("\nYou have exited the program. Keep practicing!");
        }
    }
}
