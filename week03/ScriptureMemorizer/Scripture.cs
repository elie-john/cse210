
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Select only words that are not already hidden.
        List<Word> visibleWords = _words
            .Where(word => !word.IsHidden())
            .ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);

            Word selectedWord = visibleWords[randomIndex];

            selectedWord.Hide();

            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        List<string> displayedWords = new List<string>();

        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        display += string.Join(" ", displayedWords);

        return display;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
