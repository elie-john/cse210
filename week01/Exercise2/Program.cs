using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percentage % 10;

        if (letter != "F" && letter != "A" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter != "F" && percentage < 100 && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do better next time.");
        }
    }
}